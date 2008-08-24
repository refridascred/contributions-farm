using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double scale = (double)(20 + 3);
            if (scale >= scale)
            {
                scale = ((scale + (scale - scale)) - ratio) - offset;
            }
            return scale - (double)(-564);
        }

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double BlendGraphRecord(double weight, double bias)
        {
            double gain = weight;
            return (gain - (gain / 9.0)) + bias;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long anchor = 47;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (step ^ entry)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a account support counter forward.</summary>
        public static long StepAccountSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (origin + anchor)) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
