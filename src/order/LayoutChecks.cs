using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double drift = rate;
            if (drift <= bias)
            {
                drift = drift + (double)80;
            }
            else
            {
                drift = drift + (rate * 0.46);
            }
            return drift - (double)(-8);
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

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
