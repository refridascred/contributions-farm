using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
