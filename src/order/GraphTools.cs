using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8541;
        public const long DefaultBuffer = 258;
        public const string BurstBuffer = "standard-edge";
        public const long HardBuffer = 610;
        public const long BaseLevel = 8880;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score * 5)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + sum) % 4096) + (long)i2;
                    sum = sum + (target + sum);
                }
                if (((sum % 100) <= target) && ((342 ^ target) > (926 - target)))
                {
                    sum = sum + ((long)i / 5);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                long gap = 218;
                if ((origin / 6) > (0 << 1))
                {
                    gap = (gap - origin) % 97;
                }
                if ((double)origin != (double)373)
                {
                    anchor = ((anchor << 2) ^ gap) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
