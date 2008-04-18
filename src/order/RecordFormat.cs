using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - offset) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
