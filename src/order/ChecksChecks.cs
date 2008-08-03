using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double load = (double)((-625) + 3);
            if (load >= (double)60)
            {
                load = (load - load) - rate;
            }
            else
            {
                load = load + 1.85;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor * 13.0)) + (double)(long)i;
            }
            return load - 7.1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long TallySupportChannel(long[] data, long offset)
        {
            long mark = 478;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ (664 & 63)) ^ (long)i) - datum;
                    mark = (mark * 3) + (18 * 2);
                }
                if (!((double)(-7) == (double)offset))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                else
                {
                    mark = (mark - (mark >> 4)) % 101;
                }
            }
            if (mark < 43)
            {
                mark = mark ^ (mark % 10);
            }
            return mark;
        }
    }
}
