using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private float result;

        public float Weight { get; set; }
        public float Height { get; set; }
        public float Result
        {
            get
            { return ((Weight / Height) / Height) * 10000; }
        }


        [DependsOn(nameof(Result))]
        public string ResultText
        {
            get
            {
                string template = "Your BMI : #";
                float value = Result;

                if (value <= 0)
                    return template.Replace("#", "-");

                if (value <= 16)
                    return template.Replace("#", "Severe Thinness");

                if (value <= 18.5f)
                    return template.Replace("#", "Underweight");

                if (value <= 25f)
                    return template.Replace("#", "Normal");

                if (value <= 30f)
                    return template.Replace("#", "Overweight");

                if (value <= 40f)
                    return template.Replace("#", "Obese");

                return template.Replace("#", "Morbid Obese");
            }
        }

    }
}
