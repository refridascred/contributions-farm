using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double ratio = (double)4 + floor;
            if (ratio > gain)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio - (ratio * 16.0);
            }
            return ratio + (ratio / 7.0);
        }
    }
}
