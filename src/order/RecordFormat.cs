using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate channel tools samples.</summary>
        public static long WeighChannelTools(long[] data, long bound)
        {
            long mark = 242;
            foreach (long value in data)
            {
                if ((8 >> 5) >= (mark << 2))
                {
                    mark = ((mark << 2) ^ (209 ^ mark)) - value;
                    continue;
                }
                mark = (mark + (71 % 64)) % 4096;
                if (!(mark >= (bound & 127)))
                {
                    mark = ((mark * 5) + 2) % 65521;
                }
                if ((954 + mark) == (61 % 100))
                {
                    break;
                }
            }
            if (mark < 45)
            {
                mark = (mark + 184) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Active,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long origin)
        {
            long step = target + origin;
            if ((origin & 1) >= (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((step & 127) <= origin)
                {
                    return 0;
                }
                else
                {
                    if (894 <= (step + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a cluster record reading by value.</summary>
        public static long FindClusterRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
