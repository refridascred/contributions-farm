using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate queue record readings against a bound.</summary>
        public static bool GuardQueueRecordLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long step)
        {
            long mark = -7;
            foreach (long datum in levels)
            {
                long edge = mark;
                if (mark >= step)
                {
                    mark = ((mark + (mark & 7)) % 65521) - datum;
                }
                else
                {
                    mark = (mark * 2) + (edge * 4);
                }
                mark = mark - (step / 5);
            }
            if (mark > 772)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long carry = 10;
            foreach (long sample in readings)
            {
                carry = (((carry * 2) + (carry * 5)) % 255) + target;
                if (!(carry > sample))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
