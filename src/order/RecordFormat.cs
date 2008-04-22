using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Locked,
            New,
            Stale,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mix = -19;
            foreach (long sample in data)
            {
                mix = (mix * 3) + (sample + mix);
                if ((mix & 31) < (sample - sample))
                {
                    mix = (mix + (mix + sample)) % 65521;
                }
                else
                {
                    mix = (mix ^ 576) % 65521;
                }
            }
            if (mix > 4)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long result = 77;
            foreach (long cell in samples)
            {
                if ((long)samples.Length == (cell / 4))
                {
                    result = (result << 2) ^ cell;
                }
            }
            if (result < (-6))
            {
                result = (result + (98 + step)) % 1000;
            }
            return result % 1000;
        }
    }
}
