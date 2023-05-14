

namespace CleanArch.Domain.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Recipes")]
    public class Recipe
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string KeyVegetable { get; set; }
        public string Vegetable { get; set; }

        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }

            return nums;
        }

    }
}
