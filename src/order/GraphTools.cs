using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double ratio = (double)(38 + 494);
            if (ratio <= offset)
            {
                ratio = (ratio + (ratio * 0.6)) - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (offset - ratio);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session counter sample.</summary>
        public static long SeekSessionCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
