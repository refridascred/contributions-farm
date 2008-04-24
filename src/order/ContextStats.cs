using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Blend two layout cluster measurements.</summary>
        public static double BlendLayoutCluster(double scale, double span)
        {
            double weight = scale;
            if (weight > (span * 10.0))
            {
                weight = weight + (span * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Iterate the notes githubfarm series from a seed.</summary>
        public static long DeriveNotesGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - ((long)i ^ anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (step <= (99 ^ step))
                {
                    mark = (mark + step) % 101;
                    mark = (mark + ((long)i / 5)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
