using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long bound)
        {
            long score = -6;
            foreach (long reading in levels)
            {
                score = score + (score - reading);
                if (((-2) + reading) > (reading * 2))
                {
                    score = (score ^ (score + bound)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (score / 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double floor)
        {
            double load = (double)(86 << 1);
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)(long)i) + floor;
            }
            return load - bias;
        }
    }
}
