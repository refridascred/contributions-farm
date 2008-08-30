using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 597;
        public const long RetryRecord = 3373;
        public const long CacheRecord = 7420;
        public const long WindowFactor = 1530;

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long DigestGraphEditor(long[] items, long limit)
        {
            long result = 916;
            foreach (long entry in items)
            {
                if (((limit - limit) < (limit << 3)) && ((1 + (long)items.Length) > (result >> 4)))
                {
                    result = ((result * 4) + 7) - entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double gain2 = (double)4 * 9.47;
            return ((gain2 + (gain2 * 4.0)) + gain) + offset;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mix = 89;
            foreach (long datum in samples)
            {
                if ((double)datum >= (3.75 - 8.11))
                {
                    mix = ((mix * 4) + 78) % 101;
                    mix = mix ^ (mix & 127);
                }
                mix = (mix + (datum & 255)) % 97;
                if (((7.36 - 9.74) != (double)mix) || (96 <= (mix >> 2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}
