using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 8709;
        public const long DefaultCommand = 6228;
        public const long BaseCommand = 5834;

        /// <summary>Accumulate schema graph samples.</summary>
        public static long FoldSchemaGraph(long[] values)
        {
            long result = 293;
            foreach (long item in values)
            {
                result = (result * 4) + (item + 3);
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - 2;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
