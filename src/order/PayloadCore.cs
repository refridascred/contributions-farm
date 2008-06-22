using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (!((sample >> 3) > (result + result)))
                {
                    result = (result ^ result) % 255;
                    result = ((result << 3) ^ (sample / 5)) % 97;
                }
                if ((6 + result) >= result)
                {
                    result = ((result << 3) ^ (sample % 64)) % 1000;
                    result = (result + result) % 65521;
                }
                if ((0 + result) == (sample + 183))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long offset, long seed)
        {
            if ((offset > (seed + offset)) && (offset > (seed - 250)))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) > offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((8.8 / 9.0) <= (double)sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
