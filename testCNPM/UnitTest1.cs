using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class LoginFormTests
    {
        [TestMethod]
        public void TestLogin_KhongNhapMatKhau()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "abc";
            string password = "";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoan()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "";
            string password = "abc";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoan_MatKhau()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "";
            string password = "";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestLogin_NhapSaiMatKhau()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "quanly";
            string password = "abc";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_NhapSaiTaiKhoan()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "abc";
            string password = "quanly123";

            bool result = loginForm.kiemTraTK(username, password);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestLogin_KhongNhap()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "";
            string password = "";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_NhapDung()
        {
            // Arrange
            BLL_TaiKhoan loginForm = new BLL_TaiKhoan();
            string username = "chiendaica";
            string password = "chiendaica";

            // Act
            bool result = loginForm.kiemTraTK(username, password);

            // Assert
            Assert.AreEqual(result, true);
        }
    }
}
