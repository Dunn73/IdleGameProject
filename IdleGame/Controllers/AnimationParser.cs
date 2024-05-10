namespace Controllers.AnimationParser;
public class AnimationParser {
    public async Task<char[][][]> ParseFramesAsync(string filePath) {
        List<char[][]> framesList = new List<char[][]>();
        List<char[]> currentFrame = new List<char[]>();

        // Read lines from the file
        string[] lines = await File.ReadAllLinesAsync(filePath);

        foreach (string line in lines) {
            // If the line is empty, it indicates the end of the current frame
            if (string.IsNullOrWhiteSpace(line)) {
                // Add the current frame to the list of frames
                framesList.Add(currentFrame.ToArray());
                // Start a new frame
                currentFrame.Clear();
            }
            else {
                // Add the line as a character array to the current frame
                currentFrame.Add(line.ToCharArray());
            }
        }

        // Add the last frame to the list if it's not empty
        if (currentFrame.Count > 0) {
            framesList.Add(currentFrame.ToArray());
        }

        return framesList.ToArray();
    }
}