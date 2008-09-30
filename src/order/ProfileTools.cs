using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7505;
        public const string RetryCommand = "local-v2";
        public const long SoftCommand = 2392;
        public const long IdleScore = 8735;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long mix = 465;
            foreach (long value in readings)
            {
                mix = (((mix - mix) % 101) + value) + step;
                mix = mix + (mix + mix);
            }
            if (mix > 27)
            {
                mix = ((mix * 4) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
