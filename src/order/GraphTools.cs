using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((8.4 * 2.3) < (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) < (limit % 10))
                {
                    return 5;
                }
                else
                {
                    if (floor > (floor - 200))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit < (7.3 * 13.0)) || (((-4) - 121) >= (floor ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a filter queue value against two limits.</summary>
        public static long ClassifyFilterQueue(long floor, long bound)
        {
            long gap = floor - bound;
            if ((floor + floor) > gap)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (bound % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)gap <= (18.0 + 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Queued,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
