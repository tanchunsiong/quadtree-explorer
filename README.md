# QuadTree Explorer

Windows Forms utility for exploring Bing Maps quadtree tiling system. Converts quadtree keys to geographic coordinates and displays corresponding map tiles. Educational tool for understanding how web mapping services structure and serve map imagery.

## Features

- Quadtree key to geographic coordinate conversion
- Bing Maps tile URL generation
- Embedded web browser for tile visualization
- Bounding box coordinate calculation (all 4 corners)
- Zoom level 18 coordinate precision
- Real-time tile preview

## Tech Stack

- **Platform**: Windows Forms, .NET Framework
- **Language**: C#
- **API**: Bing Maps Tile System
- **Utilities**: Custom quadtree coordinate conversion functions

## How Quadtrees Work

Bing Maps (Virtual Earth) uses quadtree tiling system to organize map imagery:

- **Zoom level 1**: 4 tiles (2x2 grid)
- **Zoom level 2**: 16 tiles (4x4 grid)
- **Zoom level n**: 4^n tiles (2^n × 2^n grid)

Each tile identified by quadtree key (quadkey): string of digits 0-3 representing path through quadtree hierarchy.

### Quadkey Format

Example: `"02313"`
- 0 = northwest quadrant
- 1 = northeast quadrant
- 2 = southwest quadrant
- 3 = southeast quadrant

Each digit represents one zoom level deeper.

## Installation

1. Open `QuadTreeExplorer.sln` in Visual Studio
2. Build solution
3. Run executable

## Usage

1. Enter quadtree key (e.g., `"02313012"`)
2. Click "Go" button
3. Application displays:
   - Map tile image
   - Bottom-left coordinates (lat/long)
   - Top-right coordinates (lat/long)
   - Top-left coordinates (lat/long)
   - Bottom-right coordinates (lat/long)

## Tile URL Pattern

```
http://r1.ortho.tiles.virtualearth.net/tiles/r{quadkey}.png?g=244&mkt=en-us&shading=hill
```

- `r{quadkey}`: Tile identifier
- `g=244`: Map generation version
- `mkt=en-us`: Market/locale
- `shading=hill`: Hillshade layer for terrain

## Coordinate Conversion

Utilities class provides conversion functions:

- `QuadKeyToBox(string quadkey)`: Converts quadkey to pixel bounding box
- `XToLongitudeAtZoom(int x, int zoom)`: Pixel X to longitude
- `YToLatitudeAtZoom(int y, int zoom)`: Pixel Y to latitude

## Use Cases

- Understanding web mapping tile systems
- Debugging map rendering issues
- Calculating geographic bounds for tile regions
- Learning quadtree spatial indexing
- Bing Maps API development reference

## License

MIT License

## Links

- Blog post: [QuadTree Explorer: Understanding Bing Maps Tiling System](https://www.tanchunsiong.com/2011/05/quadtree-explorer-understanding-bing-maps-tiling-system/)
- GitHub: [github.com/tanchunsiong](https://github.com/tanchunsiong)
- LinkedIn: [linkedin.com/in/tanchunsiong](https://linkedin.com/in/tanchunsiong)
- X: [x.com/tanchunsiong](https://x.com/tanchunsiong)

**Project Created:** 2010-2011
