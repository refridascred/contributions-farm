using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i <= (carry / 9))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of payload metrics entries.</summary>
        public static long ScorePayloadMetrics(long[] series, long step)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                if (mix > reading)
                {
                    mix = (mix + (reading * 5)) - step;
                }
                if ((7 / 6) <= (long)series.Length)
                {
                    mix = (mix + ((-2) + 67)) % 65521;
                }
            }
            return mix;
        }
    }
}
