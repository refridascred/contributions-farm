using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 8109;
        public const long WindowContributi = 5517;
        public const long HardContributi = 2322;
        public const long IdleWidth = 4313;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Dropped,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
