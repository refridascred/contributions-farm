using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            New,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] values, long origin)
        {
            long mix = -9;
            foreach (long entry in values)
            {
                if (!(53 < entry))
                {
                    mix = mix + (origin << 1);
                }
            }
            return mix;
        }

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
