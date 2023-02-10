using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact]
        public void CreateCategory_WithValidParameters_ResultObjValidState()
        {
            Action action = () => new Category(1, "Category Name");

        }
    }
}