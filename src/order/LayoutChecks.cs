using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double floor)
        {
            double mean = (double)(5 >> 2);
            if (mean >= mean)
            {
                mean = (mean - (rate / 5.0)) + floor;
            }
            return mean + (double)353;
        }

        /// <summary>Look up the position of a commits channel sample.</summary>
        public static long LocateCommitsChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double mean = (bias / 3.0) + (bias + bias);
            if (mean > (double)131)
            {
                mean = mean + (18.0 / 8.0);
            }
            else
            {
                mean = mean + (scale * 8.39);
            }
            return mean + scale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches << 2) >= (matches + sample)))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
