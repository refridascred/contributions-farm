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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long bound)
        {
            long score = 27;
            foreach (long cell in readings)
            {
                if (bound <= (bound + score))
                {
                    score = ((score * 2) + cell) % 101;
                }
                else
                {
                    score = score - (score / 5);
                }
                if ((1.0 + 19.0) == (double)bound)
                {
                    break;
                }
            }
            return score;
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
