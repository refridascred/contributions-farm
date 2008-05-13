using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long offset)
        {
            long mix = 673;
            foreach (long value in samples)
            {
                if ((mix / 6) >= (offset >> 1))
                {
                    mix = (((mix << 3) ^ (14 >> 1)) % 65521) ^ value;
                }
            }
            if (mix > 777)
            {
                mix = mix - (offset % 12);
            }
            return mix;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
