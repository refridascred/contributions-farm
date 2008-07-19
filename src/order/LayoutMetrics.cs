using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = (double)8 / 9.0;
            if (gain >= (double)593)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (8.39 + bias);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long score = 609;
            foreach (long reading in samples)
            {
                score = ((score * 3) + ((long)samples.Length - reading)) + limit;
            }
            return score;
        }
    }
}
