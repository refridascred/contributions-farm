using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metrics route samples.</summary>
        public static long MatchMetricsRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (((7.0 - 5.3) >= (double)target) || ((double)(long)i >= 6.0))
                {
                    carry = (carry + (target + target)) % 97;
                    carry = (carry - (carry >> 4)) % 65521;
                    break;
                }
                if (((long)i % 10) == (long)i)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double ratio = (double)(843 ^ 892);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) - rate) + span;
            }
            return ratio - (double)2;
        }

        /// <summary>Classify a record window pair into a bucket.</summary>
        public static long ClassifyRecordWindow(long origin, long floor)
        {
            long step = origin + floor;
            if ((floor - 18) == ((-543) - step))
            {
                return 3;
            }
            else
            {
                if ((double)step == (3.68 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (step <= (floor & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
