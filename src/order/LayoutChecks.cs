using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 323;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + (anchor % 3)) ^ sample;
            }
            if (anchor > 486)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            if (0 > (origin - floor))
            {
                return 2;
            }
            else
            {
                if ((origin + 2) != (floor - origin))
                {
                    return 6;
                }
                else
                {
                    if (((floor / 6) < (floor - (-779))) && (origin > (floor + floor)))
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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((3.86 < (double)(long)series.Length) || ((double)offset < 7.8))
                {
                    result = result ^ (0 - offset);
                }
                if (((double)cell > (double)result) || ((offset & 127) > (result - cell)))
                {
                    result = result ^ (result - result);
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result ^ offset)) % 97;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardSpan = 17.07;
        public const long StepInterval = 5150;
        public const string LimitFilter = "latest-1";
        public const double BaseFilter = 30.34;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
