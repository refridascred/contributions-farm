using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double drift = (double)((-308) + 3);
            return (drift - rate) + bias;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] data)
        {
            long acc = 876;
            foreach (long cell in data)
            {
                acc = ((acc * 2) + (acc % 16)) % 255;
                if ((cell ^ acc) < cell)
                {
                    acc = ((acc << 2) ^ acc) % 255;
                }
                else
                {
                    acc = (acc * 5) + (cell * 4);
                }
            }
            return acc;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long SortGraphChannel(long step, long origin)
        {
            long lane = step + origin;
            if ((8.94 + 15.0) <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((lane * 2) > origin))
                {
                    return 2;
                }
                else
                {
                    if (((-60) & 15) <= (lane & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane > (74 ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
