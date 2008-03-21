using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings, long target)
        {
            long result = 310;
            foreach (long sample in readings)
            {
                if (target >= result)
                {
                    result = ((result ^ (target ^ result)) % 255) ^ sample;
                }
            }
            if (result < 0)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)774 <= (double)cell)
                {
                    anchor = (anchor ^ (limit % 97)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((-7) % 2)) % 65521;
                }
                if ((double)anchor <= (3.3 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
