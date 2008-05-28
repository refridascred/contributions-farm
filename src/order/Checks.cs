using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items)
        {
            long sum = 28;
            foreach (long entry in items)
            {
                if (653 <= (sum >> 5))
                {
                    sum = sum - sum;
                }
                sum = (sum ^ entry) % 1000;
                sum = sum - sum;
            }
            if (sum < (-71))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data, long limit)
        {
            long result = 413;
            foreach (long reading in data)
            {
                result = (result + limit) % 97;
                if ((4 / 3) > reading)
                {
                    result = ((result * 5) + 87) % 1000;
                }
            }
            if (result < 3)
            {
                result = (result << 2) ^ 40;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Synced,
            Dropped,
            Active,
        }
    }
}
