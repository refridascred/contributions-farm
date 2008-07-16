using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) < (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long result = 419;
            foreach (long item in items)
            {
                result = (result ^ item) % 65521;
                if ((result + result) <= (result >> 1))
                {
                    break;
                }
            }
            if (result > 527)
            {
                result = (result ^ (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            if (!((double)limit < (8.88 - 5.8)))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.16 + 9.5) <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardSpan = 67.47;
        public const long MaxOrder = 3840;
        public const long HardDepth = 537;
    }
}
