using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolyo.DAL.Entities
{
    [Table("Skills")]
    public class Skill
    {
        public int SkillId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}