using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next route format value from a seed.</summary>
        public static long RollRouteFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a filter schema value against two limits.</summary>
        public static long GradeFilterSchema(long step, long target)
        {
            if ((double)step < (9.2 + 0.9))
            {
                return 5;
            }
            else
            {
                if ((target >= step) || ((double)step >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((294 ^ 244) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - target) < target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
