using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mark + offset) >= offset)
                {
                    mark = ((mark << 2) ^ (mark / 2)) % 65521;
                    mark = (mark + (mark >> 3)) % 101;
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i - mark)) % 1000;
                    mark = (mark - mark) % 4096;
                }
                if (!(mark < offset))
                {
                    mark = (mark + (mark % 7)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((158 >> 2) > (origin - tally)) || ((tally * 2) >= (reading ^ reading))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
