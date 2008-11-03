using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((750 + bound) == (step * 2))
            {
                return 3;
            }
            else
            {
                if (step <= (bound % 8))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 3) + ((long)i - (long)i);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit farm editor readings against a rule.</summary>
        public static long MeasureFarmEditorGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading / 4) >= (long)series.Length))
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
