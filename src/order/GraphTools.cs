using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long offset)
        {
            long mix = 82;
            foreach (long item in samples)
            {
                if (((offset + 39) <= (mix & 127)) && ((offset - mix) < (mix >> 3)))
                {
                    mix = ((mix * 5) + (23 ^ 5)) - item;
                }
            }
            return mix;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long mark = -6;
            foreach (long entry in series)
            {
                if ((limit + entry) < (757 - limit))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
