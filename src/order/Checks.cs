using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + seen) > 895)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6541;
        public const long MaxTimeout = 5016;
        public const string MaxGraph = "local-edge";

        /// <summary>Derive the next channel tools value from a seed.</summary>
        public static long IterateChannelTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = (anchor << 3) ^ anchor;
                anchor = (anchor << 3) ^ (anchor + step);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double load = (double)4 * 1.68;
            if (load > load)
            {
                load = (load - offset) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 0.5) + (double)(long)i;
            }
            return load + (load * 3.0);
        }
    }
}
