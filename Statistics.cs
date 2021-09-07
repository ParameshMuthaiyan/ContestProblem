using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Statistics
    {
        //float[] mark;
        //public Statistics(float[] markList)
        //{
        //    this.mark = markList;
        //}
        //public float[] mark
        //{
        //    get { return mark; }
        //    set { mark = value; }
        //}

        public float Avg(float[] markList)
        {
            float sum = 0;
            for (int i = 0; i < markList.Length; i++)
            {
                sum += markList[i];
            }
            return sum / markList.Length;
        }

        public float Maximum(float[] markList)
        {
            float max = markList[0];
            for (int i = 0; i < markList.Length; i++)
            {
                max = Math.Max(max, markList[i]);
            }
            return max;
        }
        public float Minimum(float[] markList)
        {
            float min = markList[0];
            for (int i = 0; i < markList.Length; i++)
            {
                min = Math.Min(min, markList[i]);
            }
            return min;
        }



    }



}
