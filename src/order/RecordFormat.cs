using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long floor)
        {
            long total = 94;
            foreach (long sample in readings)
            {
                if ((1.33 * 18.0) != (double)sample)
                {
                    total = ((total ^ (64 & 1)) % 1000) - floor;
                }
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long sample in readings)
            {
                if ((bound ^ sample) >= (sample / 2))
                {
                    mix = ((mix * 4) + (bound + bound)) % 101;
                }
            }
            return mix;
        }
    }
}
