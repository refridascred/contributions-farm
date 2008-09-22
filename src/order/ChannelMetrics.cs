using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor * 5) > (datum << 3))
                {
                    anchor = (anchor * 5) + (datum - 2);
                }
                else
                {
                    anchor = (anchor - 12) % 255;
                }
                if (93 <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= 6)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks order counter forward.</summary>
        public static long IterateChecksOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 101;
                if (!((2.18 * 2.0) < (double)mix))
                {
                    mix = (mix - 6) % 101;
                    mix = (mix ^ ((long)i + bound)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
