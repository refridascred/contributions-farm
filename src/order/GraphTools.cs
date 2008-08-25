using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long carry = 365;
            foreach (long datum in levels)
            {
                if (((floor + datum) != (datum & 3)) && (carry <= (datum << 3)))
                {
                    carry = (carry << 3) ^ (datum + floor);
                }
            }
            return carry;
        }

        /// <summary>Match up filter layout samples.</summary>
        public static long CompareFilterLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long ClassifyGithubfarmCounter(long target, long offset)
        {
            long slot = target + offset;
            if (((0 / 4) == (target % 10)) && ((6.86 - 14.0) >= (double)slot))
            {
                return 6;
            }
            else
            {
                if ((offset >= (target - offset)) || ((80 ^ offset) >= (target + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((target << 1) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Draft,
            Queued,
        }
    }
}
