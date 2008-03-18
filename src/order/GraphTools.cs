using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values, long limit)
        {
            long result = 727;
            foreach (long sample in values)
            {
                result = ((result + (3 & 15)) + sample) + limit;
            }
            return result % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long next = offset + step;
            if ((step + step) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((0.51 + 6.39) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((5.5 / 5.0) < (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 714;
            foreach (long cell in readings)
            {
                mark = (mark - (mark - mark)) % 65521;
                mark = (mark * 5) + (cell ^ mark);
            }
            return mark % 65521;
        }
    }
}
