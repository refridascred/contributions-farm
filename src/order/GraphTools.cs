using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ 114) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] samples, long step)
        {
            long total = -35;
            foreach (long sample in samples)
            {
                if (((double)step > (2.1 * 4.55)) || ((19.0 - 4.0) <= (5.74 + 11.0)))
                {
                    total = (total ^ 8) % 101;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total ^ step)) % 255;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits != (7.8 + 3.6))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
