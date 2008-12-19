using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 - 0.9) > (double)origin))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a contributi support counter forward.</summary>
        public static long RollContributiSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long MeasureSupportEditorMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) != (datum + datum))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
