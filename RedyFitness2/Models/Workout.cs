using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedyFitness2.Models
{
    public class WorkoutModel
    {
        
        public List<string> ExerciseList = new List<string>
           (new string[]
           {
                "Deadlift",
                "Bench Press",
                "Squat",
                "Shoulder Press",
           });
        
       
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Reps")]
        public int maxReps { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public double maxWeight { get; set; }

        [Required]
        [Display(Name = "Exercises")]
        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public string Notes { get; set; }
    }
}