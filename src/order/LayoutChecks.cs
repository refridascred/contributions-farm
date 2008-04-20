using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - acc) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc - (acc & 63)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                double mean = (double)(mark << 2);
                if ((offset < (mark - (long)i)) && (15.0 > mean))
                {
                    mark = mark ^ 7;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a support contributi pair into a bucket.</summary>
        public static long RankSupportContributi(long bound, long target)
        {
            long span = bound ^ target;
            if (((bound ^ 29) > (span & 31)) && ((span >> 1) <= bound))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) > (target - 102))
                {
                    return 0;
                }
                else
                {
                    if ((target + span) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((3.2 - 4.0) != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) > (slot - slot))
                {
                    return 8;
                }
                else
                {
                    if (!((707 / 6) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor >= (floor - 394)) || ((floor - 202) == (floor ^ slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
