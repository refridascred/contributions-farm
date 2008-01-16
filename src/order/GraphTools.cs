using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < step)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 100;
            foreach (long sample in data)
            {
                if (((mix ^ sample) < mix) && (50 >= (mix * 2)))
                {
                    mix = (mix - (sample - (-160))) % 4096;
                }
                else
                {
                    mix = (mix + ((long)data.Length ^ mix)) % 4096;
                }
            }
            return mix;
        }
    }
}
