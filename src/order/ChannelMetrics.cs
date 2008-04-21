using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long bound)
        {
            long gap = floor + bound;
            if (952 > (floor % 8))
            {
                return 6;
            }
            else
            {
                if ((gap & 15) != ((-44) % 100))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a editor schema value against two limits.</summary>
        public static long ClassifyEditorSchema(long limit, long origin)
        {
            if ((limit + limit) != (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (77 >= (limit - origin))
                {
                    return 3;
                }
                else
                {
                    if ((7.8 / 2.0) > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >= (limit ^ origin)) && (limit <= (origin / 8)))
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
}
