using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long limit)
        {
            long cur = origin - limit;
            if ((limit % 16) < (cur / 9))
            {
                return 5;
            }
            else
            {
                if ((double)origin > (9.28 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 255) == (6 / 8)) || ((cur - cur) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((cur % 2) < (limit ^ limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
