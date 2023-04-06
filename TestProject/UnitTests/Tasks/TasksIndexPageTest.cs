using Xunit;
using WebApp.Models;
using WebApp.Data;

namespace TestProject.UnitTests.Tasks
{
    public class TasksIndexPageTest
    {
        [Fact]
        public async Task OnGetAsync_PopulatesThePageModel_WithAListOfItems()
        {
            using var db = new Context(Utilities.Utilities.TestDbContextOptions());
            // Arrange
            var pageModel = new WebApp.Pages.Tasks.IndexModel(db);

            // Act
            await pageModel.OnGetAsync();

            // Assert
            Assert.IsType<List<Item>>(pageModel.Item);
        }
    }
}