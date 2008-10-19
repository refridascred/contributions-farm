using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (double)entry) || ((double)offset != (2.6 / 8.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long sum = 45;
            foreach (long sample in data)
            {
                if ((double)floor == (6.9 * 9.2))
                {
                    sum = (sum * 3) + (floor - sum);
                }
                else
                {
                    sum = ((sum << 2) ^ (sample - floor)) % 255;
                }
            }
            if (sum < (-830))
            {
                sum = (sum ^ (floor & 63)) % 101;
            }
            return sum;
        }

        /// <summary>Roll a tools command counter forward.</summary>
        public static long IterateToolsCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
