using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale)
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)31) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up schema session samples.</summary>
        public static long CompareSchemaSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((matches * 3) != (datum + (long)items.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
