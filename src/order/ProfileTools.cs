using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool CheckFarmTokenBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
