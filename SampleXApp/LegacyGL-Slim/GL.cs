// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

#pragma warning disable CS0649

public unsafe static class GL
{
    #region Enums
    public const uint GL_DEPTH_BUFFER_BIT = 0x00000100u;
    public const uint GL_STENCIL_BUFFER_BIT = 0x00000400u;
    public const uint GL_COLOR_BUFFER_BIT = 0x00004000u;
    public const uint GL_FALSE = 0u;
    public const uint GL_TRUE = 1u;
    public const uint GL_POINTS = 0x0000u;
    public const uint GL_LINES = 0x0001u;
    public const uint GL_LINE_LOOP = 0x0002u;
    public const uint GL_LINE_STRIP = 0x0003u;
    public const uint GL_TRIANGLES = 0x0004u;
    public const uint GL_TRIANGLE_STRIP = 0x0005u;
    public const uint GL_TRIANGLE_FAN = 0x0006u;
    public const uint GL_QUADS = 0x0007u;
    public const uint GL_NEVER = 0x0200u;
    public const uint GL_LESS = 0x0201u;
    public const uint GL_EQUAL = 0x0202u;
    public const uint GL_LEQUAL = 0x0203u;
    public const uint GL_GREATER = 0x0204u;
    public const uint GL_NOTEQUAL = 0x0205u;
    public const uint GL_GEQUAL = 0x0206u;
    public const uint GL_ALWAYS = 0x0207u;
    public const uint GL_ZERO = 0u;
    public const uint GL_ONE = 1u;
    public const uint GL_SRC_COLOR = 0x0300u;
    public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301u;
    public const uint GL_SRC_ALPHA = 0x0302u;
    public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303u;
    public const uint GL_DST_ALPHA = 0x0304u;
    public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305u;
    public const uint GL_DST_COLOR = 0x0306u;
    public const uint GL_ONE_MINUS_DST_COLOR = 0x0307u;
    public const uint GL_SRC_ALPHA_SATURATE = 0x0308u;
    public const uint GL_NONE = 0u;
    public const uint GL_FRONT_LEFT = 0x0400u;
    public const uint GL_FRONT_RIGHT = 0x0401u;
    public const uint GL_BACK_LEFT = 0x0402u;
    public const uint GL_BACK_RIGHT = 0x0403u;
    public const uint GL_FRONT = 0x0404u;
    public const uint GL_BACK = 0x0405u;
    public const uint GL_LEFT = 0x0406u;
    public const uint GL_RIGHT = 0x0407u;
    public const uint GL_FRONT_AND_BACK = 0x0408u;
    public const uint GL_NO_ERROR = 0u;
    public const uint GL_INVALID_ENUM = 0x0500u;
    public const uint GL_INVALID_VALUE = 0x0501u;
    public const uint GL_INVALID_OPERATION = 0x0502u;
    public const uint GL_OUT_OF_MEMORY = 0x0505u;
    public const uint GL_CW = 0x0900u;
    public const uint GL_CCW = 0x0901u;
    public const uint GL_POINT_SIZE = 0x0B11u;
    public const uint GL_POINT_SIZE_RANGE = 0x0B12u;
    public const uint GL_POINT_SIZE_GRANULARITY = 0x0B13u;
    public const uint GL_LINE_SMOOTH = 0x0B20u;
    public const uint GL_LINE_WIDTH = 0x0B21u;
    public const uint GL_LINE_WIDTH_RANGE = 0x0B22u;
    public const uint GL_LINE_WIDTH_GRANULARITY = 0x0B23u;
    public const uint GL_POLYGON_MODE = 0x0B40u;
    public const uint GL_POLYGON_SMOOTH = 0x0B41u;
    public const uint GL_CULL_FACE = 0x0B44u;
    public const uint GL_CULL_FACE_MODE = 0x0B45u;
    public const uint GL_FRONT_FACE = 0x0B46u;
    public const uint GL_DEPTH_RANGE = 0x0B70u;
    public const uint GL_DEPTH_TEST = 0x0B71u;
    public const uint GL_DEPTH_WRITEMASK = 0x0B72u;
    public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73u;
    public const uint GL_DEPTH_FUNC = 0x0B74u;
    public const uint GL_STENCIL_TEST = 0x0B90u;
    public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91u;
    public const uint GL_STENCIL_FUNC = 0x0B92u;
    public const uint GL_STENCIL_VALUE_MASK = 0x0B93u;
    public const uint GL_STENCIL_FAIL = 0x0B94u;
    public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95u;
    public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96u;
    public const uint GL_STENCIL_REF = 0x0B97u;
    public const uint GL_STENCIL_WRITEMASK = 0x0B98u;
    public const uint GL_VIEWPORT = 0x0BA2u;
    public const uint GL_DITHER = 0x0BD0u;
    public const uint GL_BLEND_DST = 0x0BE0u;
    public const uint GL_BLEND_SRC = 0x0BE1u;
    public const uint GL_BLEND = 0x0BE2u;
    public const uint GL_LOGIC_OP_MODE = 0x0BF0u;
    public const uint GL_COLOR_LOGIC_OP = 0x0BF2u;
    public const uint GL_DRAW_BUFFER = 0x0C01u;
    public const uint GL_READ_BUFFER = 0x0C02u;
    public const uint GL_SCISSOR_BOX = 0x0C10u;
    public const uint GL_SCISSOR_TEST = 0x0C11u;
    public const uint GL_COLOR_CLEAR_VALUE = 0x0C22u;
    public const uint GL_COLOR_WRITEMASK = 0x0C23u;
    public const uint GL_DOUBLEBUFFER = 0x0C32u;
    public const uint GL_STEREO = 0x0C33u;
    public const uint GL_LINE_SMOOTH_HINT = 0x0C52u;
    public const uint GL_POLYGON_SMOOTH_HINT = 0x0C53u;
    public const uint GL_UNPACK_SWAP_BYTES = 0x0CF0u;
    public const uint GL_UNPACK_LSB_FIRST = 0x0CF1u;
    public const uint GL_UNPACK_ROW_LENGTH = 0x0CF2u;
    public const uint GL_UNPACK_SKIP_ROWS = 0x0CF3u;
    public const uint GL_UNPACK_SKIP_PIXELS = 0x0CF4u;
    public const uint GL_UNPACK_ALIGNMENT = 0x0CF5u;
    public const uint GL_PACK_SWAP_BYTES = 0x0D00u;
    public const uint GL_PACK_LSB_FIRST = 0x0D01u;
    public const uint GL_PACK_ROW_LENGTH = 0x0D02u;
    public const uint GL_PACK_SKIP_ROWS = 0x0D03u;
    public const uint GL_PACK_SKIP_PIXELS = 0x0D04u;
    public const uint GL_PACK_ALIGNMENT = 0x0D05u;
    public const uint GL_MAX_TEXTURE_SIZE = 0x0D33u;
    public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3Au;
    public const uint GL_SUBPIXEL_BITS = 0x0D50u;
    public const uint GL_TEXTURE_1D = 0x0DE0u;
    public const uint GL_TEXTURE_2D = 0x0DE1u;
    public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00u;
    public const uint GL_POLYGON_OFFSET_POINT = 0x2A01u;
    public const uint GL_POLYGON_OFFSET_LINE = 0x2A02u;
    public const uint GL_POLYGON_OFFSET_FILL = 0x8037u;
    public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038u;
    public const uint GL_TEXTURE_BINDING_1D = 0x8068u;
    public const uint GL_TEXTURE_BINDING_2D = 0x8069u;
    public const uint GL_TEXTURE_WIDTH = 0x1000u;
    public const uint GL_TEXTURE_HEIGHT = 0x1001u;
    public const uint GL_TEXTURE_INTERNAL_FORMAT = 0x1003u;
    public const uint GL_TEXTURE_BORDER_COLOR = 0x1004u;
    public const uint GL_TEXTURE_RED_SIZE = 0x805Cu;
    public const uint GL_TEXTURE_GREEN_SIZE = 0x805Du;
    public const uint GL_TEXTURE_BLUE_SIZE = 0x805Eu;
    public const uint GL_TEXTURE_ALPHA_SIZE = 0x805Fu;
    public const uint GL_DONT_CARE = 0x1100u;
    public const uint GL_FASTEST = 0x1101u;
    public const uint GL_NICEST = 0x1102u;
    public const uint GL_BYTE = 0x1400u;
    public const uint GL_UNSIGNED_BYTE = 0x1401u;
    public const uint GL_SHORT = 0x1402u;
    public const uint GL_UNSIGNED_SHORT = 0x1403u;
    public const uint GL_INT = 0x1404u;
    public const uint GL_UNSIGNED_INT = 0x1405u;
    public const uint GL_FLOAT = 0x1406u;
    public const uint GL_DOUBLE = 0x140Au;
    public const uint GL_STACK_OVERFLOW = 0x0503u;
    public const uint GL_STACK_UNDERFLOW = 0x0504u;
    public const uint GL_CLEAR = 0x1500u;
    public const uint GL_AND = 0x1501u;
    public const uint GL_AND_REVERSE = 0x1502u;
    public const uint GL_COPY = 0x1503u;
    public const uint GL_AND_INVERTED = 0x1504u;
    public const uint GL_NOOP = 0x1505u;
    public const uint GL_XOR = 0x1506u;
    public const uint GL_OR = 0x1507u;
    public const uint GL_NOR = 0x1508u;
    public const uint GL_EQUIV = 0x1509u;
    public const uint GL_INVERT = 0x150Au;
    public const uint GL_OR_REVERSE = 0x150Bu;
    public const uint GL_COPY_INVERTED = 0x150Cu;
    public const uint GL_OR_INVERTED = 0x150Du;
    public const uint GL_NAND = 0x150Eu;
    public const uint GL_SET = 0x150Fu;
    public const uint GL_TEXTURE = 0x1702u;
    public const uint GL_COLOR = 0x1800u;
    public const uint GL_DEPTH = 0x1801u;
    public const uint GL_STENCIL = 0x1802u;
    public const uint GL_STENCIL_INDEX = 0x1901u;
    public const uint GL_DEPTH_COMPONENT = 0x1902u;
    public const uint GL_RED = 0x1903u;
    public const uint GL_GREEN = 0x1904u;
    public const uint GL_BLUE = 0x1905u;
    public const uint GL_ALPHA = 0x1906u;
    public const uint GL_RGB = 0x1907u;
    public const uint GL_RGBA = 0x1908u;
    public const uint GL_POINT = 0x1B00u;
    public const uint GL_LINE = 0x1B01u;
    public const uint GL_FILL = 0x1B02u;
    public const uint GL_KEEP = 0x1E00u;
    public const uint GL_REPLACE = 0x1E01u;
    public const uint GL_INCR = 0x1E02u;
    public const uint GL_DECR = 0x1E03u;
    public const uint GL_VENDOR = 0x1F00u;
    public const uint GL_RENDERER = 0x1F01u;
    public const uint GL_VERSION = 0x1F02u;
    public const uint GL_EXTENSIONS = 0x1F03u;
    public const uint GL_NEAREST = 0x2600u;
    public const uint GL_LINEAR = 0x2601u;
    public const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700u;
    public const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701u;
    public const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702u;
    public const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703u;
    public const uint GL_TEXTURE_MAG_FILTER = 0x2800u;
    public const uint GL_TEXTURE_MIN_FILTER = 0x2801u;
    public const uint GL_TEXTURE_WRAP_S = 0x2802u;
    public const uint GL_TEXTURE_WRAP_T = 0x2803u;
    public const uint GL_PROXY_TEXTURE_1D = 0x8063u;
    public const uint GL_PROXY_TEXTURE_2D = 0x8064u;
    public const uint GL_REPEAT = 0x2901u;
    public const uint GL_R3_G3_B2 = 0x2A10u;
    public const uint GL_RGB4 = 0x804Fu;
    public const uint GL_RGB5 = 0x8050u;
    public const uint GL_RGB8 = 0x8051u;
    public const uint GL_RGB10 = 0x8052u;
    public const uint GL_RGB12 = 0x8053u;
    public const uint GL_RGB16 = 0x8054u;
    public const uint GL_RGBA2 = 0x8055u;
    public const uint GL_RGBA4 = 0x8056u;
    public const uint GL_RGB5_A1 = 0x8057u;
    public const uint GL_RGBA8 = 0x8058u;
    public const uint GL_RGB10_A2 = 0x8059u;
    public const uint GL_RGBA12 = 0x805Au;
    public const uint GL_RGBA16 = 0x805Bu;
    public const uint GL_CURRENT_BIT = 0x00000001u;
    public const uint GL_POINT_BIT = 0x00000002u;
    public const uint GL_LINE_BIT = 0x00000004u;
    public const uint GL_POLYGON_BIT = 0x00000008u;
    public const uint GL_POLYGON_STIPPLE_BIT = 0x00000010u;
    public const uint GL_PIXEL_MODE_BIT = 0x00000020u;
    public const uint GL_LIGHTING_BIT = 0x00000040u;
    public const uint GL_FOG_BIT = 0x00000080u;
    public const uint GL_ACCUM_BUFFER_BIT = 0x00000200u;
    public const uint GL_VIEWPORT_BIT = 0x00000800u;
    public const uint GL_TRANSFORM_BIT = 0x00001000u;
    public const uint GL_ENABLE_BIT = 0x00002000u;
    public const uint GL_HINT_BIT = 0x00008000u;
    public const uint GL_EVAL_BIT = 0x00010000u;
    public const uint GL_LIST_BIT = 0x00020000u;
    public const uint GL_TEXTURE_BIT = 0x00040000u;
    public const uint GL_SCISSOR_BIT = 0x00080000u;
    public const uint GL_ALL_ATTRIB_BITS = 0xFFFFFFFFu;
    public const uint GL_CLIENT_PIXEL_STORE_BIT = 0x00000001u;
    public const uint GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002u;
    public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFFu;
    public const uint GL_QUAD_STRIP = 0x0008u;
    public const uint GL_POLYGON = 0x0009u;
    public const uint GL_ACCUM = 0x0100u;
    public const uint GL_LOAD = 0x0101u;
    public const uint GL_RETURN = 0x0102u;
    public const uint GL_MULT = 0x0103u;
    public const uint GL_ADD = 0x0104u;
    public const uint GL_AUX0 = 0x0409u;
    public const uint GL_AUX1 = 0x040Au;
    public const uint GL_AUX2 = 0x040Bu;
    public const uint GL_AUX3 = 0x040Cu;
    public const uint GL_2D = 0x0600u;
    public const uint GL_3D = 0x0601u;
    public const uint GL_3D_COLOR = 0x0602u;
    public const uint GL_3D_COLOR_TEXTURE = 0x0603u;
    public const uint GL_4D_COLOR_TEXTURE = 0x0604u;
    public const uint GL_PASS_THROUGH_TOKEN = 0x0700u;
    public const uint GL_POINT_TOKEN = 0x0701u;
    public const uint GL_LINE_TOKEN = 0x0702u;
    public const uint GL_POLYGON_TOKEN = 0x0703u;
    public const uint GL_BITMAP_TOKEN = 0x0704u;
    public const uint GL_DRAW_PIXEL_TOKEN = 0x0705u;
    public const uint GL_COPY_PIXEL_TOKEN = 0x0706u;
    public const uint GL_LINE_RESET_TOKEN = 0x0707u;
    public const uint GL_EXP = 0x0800u;
    public const uint GL_EXP2 = 0x0801u;
    public const uint GL_COEFF = 0x0A00u;
    public const uint GL_ORDER = 0x0A01u;
    public const uint GL_DOMAIN = 0x0A02u;
    public const uint GL_PIXEL_MAP_I_TO_I = 0x0C70u;
    public const uint GL_PIXEL_MAP_S_TO_S = 0x0C71u;
    public const uint GL_PIXEL_MAP_I_TO_R = 0x0C72u;
    public const uint GL_PIXEL_MAP_I_TO_G = 0x0C73u;
    public const uint GL_PIXEL_MAP_I_TO_B = 0x0C74u;
    public const uint GL_PIXEL_MAP_I_TO_A = 0x0C75u;
    public const uint GL_PIXEL_MAP_R_TO_R = 0x0C76u;
    public const uint GL_PIXEL_MAP_G_TO_G = 0x0C77u;
    public const uint GL_PIXEL_MAP_B_TO_B = 0x0C78u;
    public const uint GL_PIXEL_MAP_A_TO_A = 0x0C79u;
    public const uint GL_VERTEX_ARRAY_POINTER = 0x808Eu;
    public const uint GL_NORMAL_ARRAY_POINTER = 0x808Fu;
    public const uint GL_COLOR_ARRAY_POINTER = 0x8090u;
    public const uint GL_INDEX_ARRAY_POINTER = 0x8091u;
    public const uint GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092u;
    public const uint GL_EDGE_FLAG_ARRAY_POINTER = 0x8093u;
    public const uint GL_FEEDBACK_BUFFER_POINTER = 0x0DF0u;
    public const uint GL_SELECTION_BUFFER_POINTER = 0x0DF3u;
    public const uint GL_CURRENT_COLOR = 0x0B00u;
    public const uint GL_CURRENT_INDEX = 0x0B01u;
    public const uint GL_CURRENT_NORMAL = 0x0B02u;
    public const uint GL_CURRENT_TEXTURE_COORDS = 0x0B03u;
    public const uint GL_CURRENT_RASTER_COLOR = 0x0B04u;
    public const uint GL_CURRENT_RASTER_INDEX = 0x0B05u;
    public const uint GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06u;
    public const uint GL_CURRENT_RASTER_POSITION = 0x0B07u;
    public const uint GL_CURRENT_RASTER_POSITION_VALID = 0x0B08u;
    public const uint GL_CURRENT_RASTER_DISTANCE = 0x0B09u;
    public const uint GL_POINT_SMOOTH = 0x0B10u;
    public const uint GL_LINE_STIPPLE = 0x0B24u;
    public const uint GL_LINE_STIPPLE_PATTERN = 0x0B25u;
    public const uint GL_LINE_STIPPLE_REPEAT = 0x0B26u;
    public const uint GL_LIST_MODE = 0x0B30u;
    public const uint GL_MAX_LIST_NESTING = 0x0B31u;
    public const uint GL_LIST_BASE = 0x0B32u;
    public const uint GL_LIST_INDEX = 0x0B33u;
    public const uint GL_POLYGON_STIPPLE = 0x0B42u;
    public const uint GL_EDGE_FLAG = 0x0B43u;
    public const uint GL_LIGHTING = 0x0B50u;
    public const uint GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51u;
    public const uint GL_LIGHT_MODEL_TWO_SIDE = 0x0B52u;
    public const uint GL_LIGHT_MODEL_AMBIENT = 0x0B53u;
    public const uint GL_SHADE_MODEL = 0x0B54u;
    public const uint GL_COLOR_MATERIAL_FACE = 0x0B55u;
    public const uint GL_COLOR_MATERIAL_PARAMETER = 0x0B56u;
    public const uint GL_COLOR_MATERIAL = 0x0B57u;
    public const uint GL_FOG = 0x0B60u;
    public const uint GL_FOG_INDEX = 0x0B61u;
    public const uint GL_FOG_DENSITY = 0x0B62u;
    public const uint GL_FOG_START = 0x0B63u;
    public const uint GL_FOG_END = 0x0B64u;
    public const uint GL_FOG_MODE = 0x0B65u;
    public const uint GL_FOG_COLOR = 0x0B66u;
    public const uint GL_ACCUM_CLEAR_VALUE = 0x0B80u;
    public const uint GL_MATRIX_MODE = 0x0BA0u;
    public const uint GL_NORMALIZE = 0x0BA1u;
    public const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3u;
    public const uint GL_PROJECTION_STACK_DEPTH = 0x0BA4u;
    public const uint GL_TEXTURE_STACK_DEPTH = 0x0BA5u;
    public const uint GL_MODELVIEW_MATRIX = 0x0BA6u;
    public const uint GL_PROJECTION_MATRIX = 0x0BA7u;
    public const uint GL_TEXTURE_MATRIX = 0x0BA8u;
    public const uint GL_ATTRIB_STACK_DEPTH = 0x0BB0u;
    public const uint GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1u;
    public const uint GL_ALPHA_TEST = 0x0BC0u;
    public const uint GL_ALPHA_TEST_FUNC = 0x0BC1u;
    public const uint GL_ALPHA_TEST_REF = 0x0BC2u;
    public const uint GL_INDEX_LOGIC_OP = 0x0BF1u;
    public const uint GL_LOGIC_OP = 0x0BF1u;
    public const uint GL_AUX_BUFFERS = 0x0C00u;
    public const uint GL_INDEX_CLEAR_VALUE = 0x0C20u;
    public const uint GL_INDEX_WRITEMASK = 0x0C21u;
    public const uint GL_INDEX_MODE = 0x0C30u;
    public const uint GL_RGBA_MODE = 0x0C31u;
    public const uint GL_RENDER_MODE = 0x0C40u;
    public const uint GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50u;
    public const uint GL_POINT_SMOOTH_HINT = 0x0C51u;
    public const uint GL_FOG_HINT = 0x0C54u;
    public const uint GL_TEXTURE_GEN_S = 0x0C60u;
    public const uint GL_TEXTURE_GEN_T = 0x0C61u;
    public const uint GL_TEXTURE_GEN_R = 0x0C62u;
    public const uint GL_TEXTURE_GEN_Q = 0x0C63u;
    public const uint GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0u;
    public const uint GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1u;
    public const uint GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2u;
    public const uint GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3u;
    public const uint GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4u;
    public const uint GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5u;
    public const uint GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6u;
    public const uint GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7u;
    public const uint GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8u;
    public const uint GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9u;
    public const uint GL_MAP_COLOR = 0x0D10u;
    public const uint GL_MAP_STENCIL = 0x0D11u;
    public const uint GL_INDEX_SHIFT = 0x0D12u;
    public const uint GL_INDEX_OFFSET = 0x0D13u;
    public const uint GL_RED_SCALE = 0x0D14u;
    public const uint GL_RED_BIAS = 0x0D15u;
    public const uint GL_ZOOM_X = 0x0D16u;
    public const uint GL_ZOOM_Y = 0x0D17u;
    public const uint GL_GREEN_SCALE = 0x0D18u;
    public const uint GL_GREEN_BIAS = 0x0D19u;
    public const uint GL_BLUE_SCALE = 0x0D1Au;
    public const uint GL_BLUE_BIAS = 0x0D1Bu;
    public const uint GL_ALPHA_SCALE = 0x0D1Cu;
    public const uint GL_ALPHA_BIAS = 0x0D1Du;
    public const uint GL_DEPTH_SCALE = 0x0D1Eu;
    public const uint GL_DEPTH_BIAS = 0x0D1Fu;
    public const uint GL_MAX_EVAL_ORDER = 0x0D30u;
    public const uint GL_MAX_LIGHTS = 0x0D31u;
    public const uint GL_MAX_CLIP_PLANES = 0x0D32u;
    public const uint GL_MAX_PIXEL_MAP_TABLE = 0x0D34u;
    public const uint GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35u;
    public const uint GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36u;
    public const uint GL_MAX_NAME_STACK_DEPTH = 0x0D37u;
    public const uint GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38u;
    public const uint GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39u;
    public const uint GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3Bu;
    public const uint GL_INDEX_BITS = 0x0D51u;
    public const uint GL_RED_BITS = 0x0D52u;
    public const uint GL_GREEN_BITS = 0x0D53u;
    public const uint GL_BLUE_BITS = 0x0D54u;
    public const uint GL_ALPHA_BITS = 0x0D55u;
    public const uint GL_DEPTH_BITS = 0x0D56u;
    public const uint GL_STENCIL_BITS = 0x0D57u;
    public const uint GL_ACCUM_RED_BITS = 0x0D58u;
    public const uint GL_ACCUM_GREEN_BITS = 0x0D59u;
    public const uint GL_ACCUM_BLUE_BITS = 0x0D5Au;
    public const uint GL_ACCUM_ALPHA_BITS = 0x0D5Bu;
    public const uint GL_NAME_STACK_DEPTH = 0x0D70u;
    public const uint GL_AUTO_NORMAL = 0x0D80u;
    public const uint GL_MAP1_COLOR_4 = 0x0D90u;
    public const uint GL_MAP1_INDEX = 0x0D91u;
    public const uint GL_MAP1_NORMAL = 0x0D92u;
    public const uint GL_MAP1_TEXTURE_COORD_1 = 0x0D93u;
    public const uint GL_MAP1_TEXTURE_COORD_2 = 0x0D94u;
    public const uint GL_MAP1_TEXTURE_COORD_3 = 0x0D95u;
    public const uint GL_MAP1_TEXTURE_COORD_4 = 0x0D96u;
    public const uint GL_MAP1_VERTEX_3 = 0x0D97u;
    public const uint GL_MAP1_VERTEX_4 = 0x0D98u;
    public const uint GL_MAP2_COLOR_4 = 0x0DB0u;
    public const uint GL_MAP2_INDEX = 0x0DB1u;
    public const uint GL_MAP2_NORMAL = 0x0DB2u;
    public const uint GL_MAP2_TEXTURE_COORD_1 = 0x0DB3u;
    public const uint GL_MAP2_TEXTURE_COORD_2 = 0x0DB4u;
    public const uint GL_MAP2_TEXTURE_COORD_3 = 0x0DB5u;
    public const uint GL_MAP2_TEXTURE_COORD_4 = 0x0DB6u;
    public const uint GL_MAP2_VERTEX_3 = 0x0DB7u;
    public const uint GL_MAP2_VERTEX_4 = 0x0DB8u;
    public const uint GL_MAP1_GRID_DOMAIN = 0x0DD0u;
    public const uint GL_MAP1_GRID_SEGMENTS = 0x0DD1u;
    public const uint GL_MAP2_GRID_DOMAIN = 0x0DD2u;
    public const uint GL_MAP2_GRID_SEGMENTS = 0x0DD3u;
    public const uint GL_FEEDBACK_BUFFER_SIZE = 0x0DF1u;
    public const uint GL_FEEDBACK_BUFFER_TYPE = 0x0DF2u;
    public const uint GL_SELECTION_BUFFER_SIZE = 0x0DF4u;
    public const uint GL_VERTEX_ARRAY = 0x8074u;
    public const uint GL_NORMAL_ARRAY = 0x8075u;
    public const uint GL_COLOR_ARRAY = 0x8076u;
    public const uint GL_INDEX_ARRAY = 0x8077u;
    public const uint GL_TEXTURE_COORD_ARRAY = 0x8078u;
    public const uint GL_EDGE_FLAG_ARRAY = 0x8079u;
    public const uint GL_VERTEX_ARRAY_SIZE = 0x807Au;
    public const uint GL_VERTEX_ARRAY_TYPE = 0x807Bu;
    public const uint GL_VERTEX_ARRAY_STRIDE = 0x807Cu;
    public const uint GL_NORMAL_ARRAY_TYPE = 0x807Eu;
    public const uint GL_NORMAL_ARRAY_STRIDE = 0x807Fu;
    public const uint GL_COLOR_ARRAY_SIZE = 0x8081u;
    public const uint GL_COLOR_ARRAY_TYPE = 0x8082u;
    public const uint GL_COLOR_ARRAY_STRIDE = 0x8083u;
    public const uint GL_INDEX_ARRAY_TYPE = 0x8085u;
    public const uint GL_INDEX_ARRAY_STRIDE = 0x8086u;
    public const uint GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088u;
    public const uint GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089u;
    public const uint GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808Au;
    public const uint GL_EDGE_FLAG_ARRAY_STRIDE = 0x808Cu;
    public const uint GL_TEXTURE_COMPONENTS = 0x1003u;
    public const uint GL_TEXTURE_BORDER = 0x1005u;
    public const uint GL_TEXTURE_LUMINANCE_SIZE = 0x8060u;
    public const uint GL_TEXTURE_INTENSITY_SIZE = 0x8061u;
    public const uint GL_TEXTURE_PRIORITY = 0x8066u;
    public const uint GL_TEXTURE_RESIDENT = 0x8067u;
    public const uint GL_AMBIENT = 0x1200u;
    public const uint GL_DIFFUSE = 0x1201u;
    public const uint GL_SPECULAR = 0x1202u;
    public const uint GL_POSITION = 0x1203u;
    public const uint GL_SPOT_DIRECTION = 0x1204u;
    public const uint GL_SPOT_EXPONENT = 0x1205u;
    public const uint GL_SPOT_CUTOFF = 0x1206u;
    public const uint GL_CONSTANT_ATTENUATION = 0x1207u;
    public const uint GL_LINEAR_ATTENUATION = 0x1208u;
    public const uint GL_QUADRATIC_ATTENUATION = 0x1209u;
    public const uint GL_COMPILE = 0x1300u;
    public const uint GL_COMPILE_AND_EXECUTE = 0x1301u;
    public const uint GL_2_BYTES = 0x1407u;
    public const uint GL_3_BYTES = 0x1408u;
    public const uint GL_4_BYTES = 0x1409u;
    public const uint GL_EMISSION = 0x1600u;
    public const uint GL_SHININESS = 0x1601u;
    public const uint GL_AMBIENT_AND_DIFFUSE = 0x1602u;
    public const uint GL_COLOR_INDEXES = 0x1603u;
    public const uint GL_MODELVIEW = 0x1700u;
    public const uint GL_PROJECTION = 0x1701u;
    public const uint GL_COLOR_INDEX = 0x1900u;
    public const uint GL_LUMINANCE = 0x1909u;
    public const uint GL_LUMINANCE_ALPHA = 0x190Au;
    public const uint GL_BITMAP = 0x1A00u;
    public const uint GL_RENDER = 0x1C00u;
    public const uint GL_FEEDBACK = 0x1C01u;
    public const uint GL_SELECT = 0x1C02u;
    public const uint GL_FLAT = 0x1D00u;
    public const uint GL_SMOOTH = 0x1D01u;
    public const uint GL_S = 0x2000u;
    public const uint GL_T = 0x2001u;
    public const uint GL_R = 0x2002u;
    public const uint GL_Q = 0x2003u;
    public const uint GL_MODULATE = 0x2100u;
    public const uint GL_DECAL = 0x2101u;
    public const uint GL_TEXTURE_ENV_MODE = 0x2200u;
    public const uint GL_TEXTURE_ENV_COLOR = 0x2201u;
    public const uint GL_TEXTURE_ENV = 0x2300u;
    public const uint GL_EYE_LINEAR = 0x2400u;
    public const uint GL_OBJECT_LINEAR = 0x2401u;
    public const uint GL_SPHERE_MAP = 0x2402u;
    public const uint GL_TEXTURE_GEN_MODE = 0x2500u;
    public const uint GL_OBJECT_PLANE = 0x2501u;
    public const uint GL_EYE_PLANE = 0x2502u;
    public const uint GL_CLAMP = 0x2900u;
    public const uint GL_ALPHA4 = 0x803Bu;
    public const uint GL_ALPHA8 = 0x803Cu;
    public const uint GL_ALPHA12 = 0x803Du;
    public const uint GL_ALPHA16 = 0x803Eu;
    public const uint GL_LUMINANCE4 = 0x803Fu;
    public const uint GL_LUMINANCE8 = 0x8040u;
    public const uint GL_LUMINANCE12 = 0x8041u;
    public const uint GL_LUMINANCE16 = 0x8042u;
    public const uint GL_LUMINANCE4_ALPHA4 = 0x8043u;
    public const uint GL_LUMINANCE6_ALPHA2 = 0x8044u;
    public const uint GL_LUMINANCE8_ALPHA8 = 0x8045u;
    public const uint GL_LUMINANCE12_ALPHA4 = 0x8046u;
    public const uint GL_LUMINANCE12_ALPHA12 = 0x8047u;
    public const uint GL_LUMINANCE16_ALPHA16 = 0x8048u;
    public const uint GL_INTENSITY = 0x8049u;
    public const uint GL_INTENSITY4 = 0x804Au;
    public const uint GL_INTENSITY8 = 0x804Bu;
    public const uint GL_INTENSITY12 = 0x804Cu;
    public const uint GL_INTENSITY16 = 0x804Du;
    public const uint GL_V2F = 0x2A20u;
    public const uint GL_V3F = 0x2A21u;
    public const uint GL_C4UB_V2F = 0x2A22u;
    public const uint GL_C4UB_V3F = 0x2A23u;
    public const uint GL_C3F_V3F = 0x2A24u;
    public const uint GL_N3F_V3F = 0x2A25u;
    public const uint GL_C4F_N3F_V3F = 0x2A26u;
    public const uint GL_T2F_V3F = 0x2A27u;
    public const uint GL_T4F_V4F = 0x2A28u;
    public const uint GL_T2F_C4UB_V3F = 0x2A29u;
    public const uint GL_T2F_C3F_V3F = 0x2A2Au;
    public const uint GL_T2F_N3F_V3F = 0x2A2Bu;
    public const uint GL_T2F_C4F_N3F_V3F = 0x2A2Cu;
    public const uint GL_T4F_C4F_N3F_V4F = 0x2A2Du;
    public const uint GL_CLIP_PLANE0 = 0x3000u;
    public const uint GL_CLIP_PLANE1 = 0x3001u;
    public const uint GL_CLIP_PLANE2 = 0x3002u;
    public const uint GL_CLIP_PLANE3 = 0x3003u;
    public const uint GL_CLIP_PLANE4 = 0x3004u;
    public const uint GL_CLIP_PLANE5 = 0x3005u;
    public const uint GL_LIGHT0 = 0x4000u;
    public const uint GL_LIGHT1 = 0x4001u;
    public const uint GL_LIGHT2 = 0x4002u;
    public const uint GL_LIGHT3 = 0x4003u;
    public const uint GL_LIGHT4 = 0x4004u;
    public const uint GL_LIGHT5 = 0x4005u;
    public const uint GL_LIGHT6 = 0x4006u;
    public const uint GL_LIGHT7 = 0x4007u;
    #endregion

    #region Delegates
    internal delegate void __e950395c(uint mode);
    internal delegate void __362ea5aa(uint mode);
    internal delegate void __2aa1c384(uint target, uint mode);
    internal delegate void __25fdfb31(float width);
    internal delegate void __1750c9cb(float size);
    internal delegate void __fc1802f1(uint face, uint mode);
    internal delegate void __db7db695(int x, int y, int width, int height);
    internal delegate void __1404d4c7(uint target, uint pname, float param);
    internal delegate void __71b46d4a(uint target, uint pname, float* @params);
    internal delegate void __aaa3c8f8(uint target, uint pname, int param);
    internal delegate void __fdde5dcd(uint target, uint pname, int* @params);
    internal delegate void __e72a31ef(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
    internal delegate void __2a38e192(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
    internal delegate void __92faf100(uint buf);
    internal delegate void __86fddee7(uint mask);
    internal delegate void __4db28fb4(float red, float green, float blue, float alpha);
    internal delegate void __987b8cdb(int s);
    internal delegate void __2b9a2760(double depth);
    internal delegate void __6b99993a(uint mask);
    internal delegate void __bad3c3bb(bool red, bool green, bool blue, bool alpha);
    internal delegate void __b863c816(bool flag);
    internal delegate void __279a6ce9(uint cap);
    internal delegate void __4ef5196b(uint cap);
    internal delegate void __dee804e7();
    internal delegate void __a7bbbd7b();
    internal delegate void __1fe19d61(uint sfactor, uint dfactor);
    internal delegate void __dcfc3621(uint opcode);
    internal delegate void __a3945d70(uint func, int @ref, uint mask);
    internal delegate void __19df7359(uint fail, uint zfail, uint zpass);
    internal delegate void __72704436(uint func);
    internal delegate void __1a1cb65d(uint pname, float param);
    internal delegate void __04ece2c5(uint pname, int param);
    internal delegate void __797b2b28(uint src);
    internal delegate void __c602ffa0(int x, int y, int width, int height, uint format, uint type, void* pixels);
    internal delegate void __84065e14(uint pname, bool* data);
    internal delegate void __42ad7abc(uint pname, double* data);
    internal delegate uint __d9a3d289();
    internal delegate void __d810b16c(uint pname, float* data);
    internal delegate void __73f4325c(uint pname, int* data);
    internal delegate byte* __798911c2(uint name);
    internal delegate void __c9181268(uint target, int level, uint format, uint type, void* pixels);
    internal delegate void __d3458f04(uint target, uint pname, float* @params);
    internal delegate void __576dc419(uint target, uint pname, int* @params);
    internal delegate void __8466b60f(uint target, int level, uint pname, float* @params);
    internal delegate void __f066a9bd(uint target, int level, uint pname, int* @params);
    internal delegate bool __a201f5d0(uint cap);
    internal delegate void __f602d7da(double near, double far);
    internal delegate void __334ad661(int x, int y, int width, int height);
    internal delegate void __ca5b9962(uint list, uint mode);
    internal delegate void __56575e48();
    internal delegate void __f3f56df4(uint list);
    internal delegate void __7e943e62(int n, uint type, void* lists);
    internal delegate void __4ba9a422(uint list, int range);
    internal delegate uint __a0b53545(int range);
    internal delegate void __df82023f(uint @base);
    internal delegate void __b1bba6dd(uint mode);
    internal delegate void __1c80402f(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
    internal delegate void __0cd3e0d7(sbyte red, sbyte green, sbyte blue);
    internal delegate void __cea8f8d5(sbyte* v);
    internal delegate void __da305434(double red, double green, double blue);
    internal delegate void __445b25ad(double* v);
    internal delegate void __6510aac8(float red, float green, float blue);
    internal delegate void __77477849(float* v);
    internal delegate void __0187a683(int red, int green, int blue);
    internal delegate void __8fa7dcee(int* v);
    internal delegate void __88dd9efc(short red, short green, short blue);
    internal delegate void __64775026(short* v);
    internal delegate void __e68eacda(byte red, byte green, byte blue);
    internal delegate void __585eb04d(byte* v);
    internal delegate void __498a96ab(uint red, uint green, uint blue);
    internal delegate void __17f9684c(uint* v);
    internal delegate void __d2bdf126(ushort red, ushort green, ushort blue);
    internal delegate void __644c855b(ushort* v);
    internal delegate void __f818f909(sbyte red, sbyte green, sbyte blue, sbyte alpha);
    internal delegate void __e997005a(sbyte* v);
    internal delegate void __d0b0e935(double red, double green, double blue, double alpha);
    internal delegate void __df24cea1(double* v);
    internal delegate void __debce663(float red, float green, float blue, float alpha);
    internal delegate void __7485c93e(float* v);
    internal delegate void __655c6548(int red, int green, int blue, int alpha);
    internal delegate void __caa13765(int* v);
    internal delegate void __cb8ec162(short red, short green, short blue, short alpha);
    internal delegate void __275f8d71(short* v);
    internal delegate void __fb48cc9a(byte red, byte green, byte blue, byte alpha);
    internal delegate void __9bede176(byte* v);
    internal delegate void __d85ce9f0(uint red, uint green, uint blue, uint alpha);
    internal delegate void __def35f14(uint* v);
    internal delegate void __cc57831b(ushort red, ushort green, ushort blue, ushort alpha);
    internal delegate void __8784f7c2(ushort* v);
    internal delegate void __a4d3b895(bool flag);
    internal delegate void __2654b995(bool* flag);
    internal delegate void __861f3bc7();
    internal delegate void __8ffc640c(double c);
    internal delegate void __e10b7a72(double* c);
    internal delegate void __3c20e00c(float c);
    internal delegate void __6c3470e3(float* c);
    internal delegate void __a8ca9879(int c);
    internal delegate void __faee0a10(int* c);
    internal delegate void __87531cfe(short c);
    internal delegate void __f52b2906(short* c);
    internal delegate void __35a38b44(sbyte nx, sbyte ny, sbyte nz);
    internal delegate void __8c5b2561(sbyte* v);
    internal delegate void __0fdee60b(double nx, double ny, double nz);
    internal delegate void __1a87f21a(double* v);
    internal delegate void __a62b80db(float nx, float ny, float nz);
    internal delegate void __6dc131f8(float* v);
    internal delegate void __60f77136(int nx, int ny, int nz);
    internal delegate void __e1331e80(int* v);
    internal delegate void __53e4e62b(short nx, short ny, short nz);
    internal delegate void __0237630f(short* v);
    internal delegate void __e34d4aff(double x, double y);
    internal delegate void __8bc8b318(double* v);
    internal delegate void __21f734c7(float x, float y);
    internal delegate void __14b23ad4(float* v);
    internal delegate void __ecf9625f(int x, int y);
    internal delegate void __4281b06d(int* v);
    internal delegate void __b61f2b73(short x, short y);
    internal delegate void __8b02b215(short* v);
    internal delegate void __dd912ffd(double x, double y, double z);
    internal delegate void __26420867(double* v);
    internal delegate void __60100c24(float x, float y, float z);
    internal delegate void __398c80e1(float* v);
    internal delegate void __04b149a6(int x, int y, int z);
    internal delegate void __7d11be0a(int* v);
    internal delegate void __795d2e9d(short x, short y, short z);
    internal delegate void __269f69be(short* v);
    internal delegate void __22a9bebf(double x, double y, double z, double w);
    internal delegate void __c10bb15b(double* v);
    internal delegate void __b82e0de2(float x, float y, float z, float w);
    internal delegate void __36cad1d6(float* v);
    internal delegate void __2904138b(int x, int y, int z, int w);
    internal delegate void __b80b1981(int* v);
    internal delegate void __837698cc(short x, short y, short z, short w);
    internal delegate void __e986a609(short* v);
    internal delegate void __cfbabaea(double x1, double y1, double x2, double y2);
    internal delegate void __18dff932(double* v1, double* v2);
    internal delegate void __3d8b727f(float x1, float y1, float x2, float y2);
    internal delegate void __c45bbd82(float* v1, float* v2);
    internal delegate void __e0afb420(int x1, int y1, int x2, int y2);
    internal delegate void __cbcdaa71(int* v1, int* v2);
    internal delegate void __6aea02f0(short x1, short y1, short x2, short y2);
    internal delegate void __0dde7f65(short* v1, short* v2);
    internal delegate void __d45a95a5(double s);
    internal delegate void __7357c9df(double* v);
    internal delegate void __6b724f36(float s);
    internal delegate void __aa5a8f0d(float* v);
    internal delegate void __8fbd9be5(int s);
    internal delegate void __dcb9e889(int* v);
    internal delegate void __20e11541(short s);
    internal delegate void __737ec49b(short* v);
    internal delegate void __ccbff864(double s, double t);
    internal delegate void __762750df(double* v);
    internal delegate void __1a4967fe(float s, float t);
    internal delegate void __6711160d(float* v);
    internal delegate void __7311b6b8(int s, int t);
    internal delegate void __7f0de589(int* v);
    internal delegate void __f114a9ce(short s, short t);
    internal delegate void __76354b9b(short* v);
    internal delegate void __d62d5b5b(double s, double t, double r);
    internal delegate void __752761df(double* v);
    internal delegate void __5f80c7fe(float s, float t, float r);
    internal delegate void __281a270d(float* v);
    internal delegate void __ebebd686(int s, int t, int r);
    internal delegate void __9e91e589(int* v);
    internal delegate void __c04ecc0c(short s, short t, short r);
    internal delegate void __753d5c9b(short* v);
    internal delegate void __3f4b1e97(double s, double t, double r, double q);
    internal delegate void __7078fcdf(double* v);
    internal delegate void __85ea6c47(float s, float t, float r, float q);
    internal delegate void __e572c20d(float* v);
    internal delegate void __942206e6(int s, int t, int r, int q);
    internal delegate void __3946ea89(int* v);
    internal delegate void __2625afd4(short s, short t, short r, short q);
    internal delegate void __7875f79b(short* v);
    internal delegate void __e49c1b0e(double x, double y);
    internal delegate void __1ac9e99a(double* v);
    internal delegate void __74642e62(float x, float y);
    internal delegate void __430581ee(float* v);
    internal delegate void __5949e42b(int x, int y);
    internal delegate void __43970266(int* v);
    internal delegate void __0bd961f7(short x, short y);
    internal delegate void __3223327b(short* v);
    internal delegate void __3a040d99(double x, double y, double z);
    internal delegate void __19c9fa9a(double* v);
    internal delegate void __9d8745cf(float x, float y, float z);
    internal delegate void __040e92ee(float* v);
    internal delegate void __5998251c(int x, int y, int z);
    internal delegate void __621b0366(int* v);
    internal delegate void __723c06ba(short x, short y, short z);
    internal delegate void __312b437b(short* v);
    internal delegate void __c7b54414(double x, double y, double z, double w);
    internal delegate void __141a969b(double* v);
    internal delegate void __2902069e(float x, float y, float z, float w);
    internal delegate void __c1662def(float* v);
    internal delegate void __b0f30bd0(int x, int y, int z, int w);
    internal delegate void __fdcf0766(int* v);
    internal delegate void __3294d0b6(short x, short y, short z, short w);
    internal delegate void __3463de7b(short* v);
    internal delegate void __d859522f(uint plane, double* equation);
    internal delegate void __3bcba941(uint face, uint mode);
    internal delegate void __ddce593e(uint pname, float param);
    internal delegate void __aef7e940(uint pname, float* @params);
    internal delegate void __4908499e(uint pname, int param);
    internal delegate void __6a0c3e92(uint pname, int* @params);
    internal delegate void __95e47d11(uint light, uint pname, float param);
    internal delegate void __c4f3a880(uint light, uint pname, float* @params);
    internal delegate void __190ffbc4(uint light, uint pname, int param);
    internal delegate void __726d17eb(uint light, uint pname, int* @params);
    internal delegate void __b278060c(uint pname, float param);
    internal delegate void __b3260152(uint pname, float* @params);
    internal delegate void __6cc17abd(uint pname, int param);
    internal delegate void __5f42a921(uint pname, int* @params);
    internal delegate void __23cee444(int factor, ushort pattern);
    internal delegate void __bbff97f6(uint face, uint pname, float param);
    internal delegate void __18ebb25a(uint face, uint pname, float* @params);
    internal delegate void __f388808e(uint face, uint pname, int param);
    internal delegate void __64162f7f(uint face, uint pname, int* @params);
    internal delegate void __246fd5f4(byte* mask);
    internal delegate void __40da144a(uint mode);
    internal delegate void __1cfdcba9(uint target, uint pname, float param);
    internal delegate void __019eb7a5(uint target, uint pname, float* @params);
    internal delegate void __52519b59(uint target, uint pname, int param);
    internal delegate void __b5c91783(uint target, uint pname, int* @params);
    internal delegate void __2ad8eaf0(uint coord, uint pname, double param);
    internal delegate void __53ae20f3(uint coord, uint pname, double* @params);
    internal delegate void __09ffcffe(uint coord, uint pname, float param);
    internal delegate void __7c4a8236(uint coord, uint pname, float* @params);
    internal delegate void __9575e3ee(uint coord, uint pname, int param);
    internal delegate void __e2a3cfc7(uint coord, uint pname, int* @params);
    internal delegate void __c07b5e08(int size, uint type, float* buffer);
    internal delegate void __77dde102(int size, uint* buffer);
    internal delegate int __2387af4a(uint mode);
    internal delegate void __65cffbae();
    internal delegate void __affed860(uint name);
    internal delegate void __02490811(float token);
    internal delegate void __9f9c5f4c();
    internal delegate void __c7ff8379(uint name);
    internal delegate void __95eee1a8(float red, float green, float blue, float alpha);
    internal delegate void __1b048ed3(float c);
    internal delegate void __4781d9a1(uint mask);
    internal delegate void __1c15bdc4(uint op, float value);
    internal delegate void __489c9d7d();
    internal delegate void __db36041e(uint mask);
    internal delegate void __337b9b25(uint target, double u1, double u2, int stride, int order, double* points);
    internal delegate void __7263f26d(uint target, float u1, float u2, int stride, int order, float* points);
    internal delegate void __08c95560(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
    internal delegate void __7bf18b7b(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
    internal delegate void __b965fa86(int un, double u1, double u2);
    internal delegate void __9f979e20(int un, float u1, float u2);
    internal delegate void __32a15f26(int un, double u1, double u2, int vn, double v1, double v2);
    internal delegate void __620f8096(int un, float u1, float u2, int vn, float v1, float v2);
    internal delegate void __75d7dc91(double u);
    internal delegate void __e7c3d5b5(double* u);
    internal delegate void __faec20e0(float u);
    internal delegate void __aa0cee40(float* u);
    internal delegate void __1576bacd(double u, double v);
    internal delegate void __4c9fcd77(double* u);
    internal delegate void __b78e37fa(float u, float v);
    internal delegate void __4f3e1210(float* u);
    internal delegate void __39c162c6(uint mode, int i1, int i2);
    internal delegate void __aa197ab7(int i);
    internal delegate void __09332c3d(uint mode, int i1, int i2, int j1, int j2);
    internal delegate void __5a98516c(int i, int j);
    internal delegate void __028c9a04(uint func, float @ref);
    internal delegate void __1536aa22(float xfactor, float yfactor);
    internal delegate void __527c14e0(uint pname, float param);
    internal delegate void __5ce387c1(uint pname, int param);
    internal delegate void __9b074d83(uint map, int mapsize, float* values);
    internal delegate void __8324eaaa(uint map, int mapsize, uint* values);
    internal delegate void __4e92517a(uint map, int mapsize, ushort* values);
    internal delegate void __db49418a(int x, int y, int width, int height, uint type);
    internal delegate void __4dcbe34b(int width, int height, uint format, uint type, void* pixels);
    internal delegate void __4692fc25(uint plane, double* equation);
    internal delegate void __669f20fd(uint light, uint pname, float* @params);
    internal delegate void __c8b6feb9(uint light, uint pname, int* @params);
    internal delegate void __af44dfb9(uint target, uint query, double* v);
    internal delegate void __8e4d1277(uint target, uint query, float* v);
    internal delegate void __ba6cd407(uint target, uint query, int* v);
    internal delegate void __3e37f3f4(uint face, uint pname, float* @params);
    internal delegate void __8249da76(uint face, uint pname, int* @params);
    internal delegate void __37232ea7(uint map, float* values);
    internal delegate void __cf6364c6(uint map, uint* values);
    internal delegate void __3807c24f(uint map, ushort* values);
    internal delegate void __ae2cfa54(byte* mask);
    internal delegate void __77f98f04(uint target, uint pname, float* @params);
    internal delegate void __b350ea0d(uint target, uint pname, int* @params);
    internal delegate void __6d944f58(uint coord, uint pname, double* @params);
    internal delegate void __86c87c31(uint coord, uint pname, float* @params);
    internal delegate void __f801871f(uint coord, uint pname, int* @params);
    internal delegate bool __33becbea(uint list);
    internal delegate void __73fb0eda(double left, double right, double bottom, double top, double zNear, double zFar);
    internal delegate void __1b5ecb65();
    internal delegate void __bd37620a(float* m);
    internal delegate void __f07f2ee3(double* m);
    internal delegate void __243b542a(uint mode);
    internal delegate void __4be38bd2(float* m);
    internal delegate void __feb81336(double* m);
    internal delegate void __3b902c5c(double left, double right, double bottom, double top, double zNear, double zFar);
    internal delegate void __b7330842();
    internal delegate void __4c4cebb6();
    internal delegate void __0cc0ada5(double angle, double x, double y, double z);
    internal delegate void __6e803879(float angle, float x, float y, float z);
    internal delegate void __3dfce7c4(double x, double y, double z);
    internal delegate void __56360ea2(float x, float y, float z);
    internal delegate void __6b320264(double x, double y, double z);
    internal delegate void __4ecdb9da(float x, float y, float z);
    internal delegate void __01d8be9e(uint mode, int first, int count);
    internal delegate void __3434f3d5(uint mode, int count, uint type, void* indices);
    internal delegate void __893b8618(uint pname, void* @params);
    internal delegate void __cafc6a15(float factor, float units);
    internal delegate void __7425775f(uint target, int level, uint internalformat, int x, int y, int width, int border);
    internal delegate void __05fa3b3d(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
    internal delegate void __c953c099(uint target, int level, int xoffset, int x, int y, int width);
    internal delegate void __b5f2e5b5(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
    internal delegate void __d109dba5(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
    internal delegate void __65dfd7a5(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
    internal delegate void __dbafbeec(uint target, uint texture);
    internal delegate void __6d2ff7b1(int n, uint* textures);
    internal delegate void __48a443e4(int n, uint* textures);
    internal delegate bool __3f0e63e4(uint texture);
    internal delegate void __d6b03661(int i);
    internal delegate void __7431f153(int size, uint type, int stride, void* pointer);
    internal delegate void __8e06463d(uint array);
    internal delegate void __b468ef7c(int stride, void* pointer);
    internal delegate void __1376a10b(uint array);
    internal delegate void __19f25888(uint type, int stride, void* pointer);
    internal delegate void __ce62da50(uint format, int stride, void* pointer);
    internal delegate void __d8589b45(uint type, int stride, void* pointer);
    internal delegate void __c5ed1c61(int size, uint type, int stride, void* pointer);
    internal delegate void __6902b086(int size, uint type, int stride, void* pointer);
    internal delegate bool __c5daf0ec(int n, uint* textures, bool* residences);
    internal delegate void __79045508(int n, uint* textures, float* priorities);
    internal delegate void __13dd9132(byte c);
    internal delegate void __71eb817e(byte* c);
    internal delegate void __317e3149();
    internal delegate void __fe512606(uint mask);
    #endregion

    #region Delegate holders
    [GLAPI("glCullFace")] internal static __e950395c _e950395c;
    [GLAPI("glFrontFace")] internal static __362ea5aa _362ea5aa;
    [GLAPI("glHint")] internal static __2aa1c384 _2aa1c384;
    [GLAPI("glLineWidth")] internal static __25fdfb31 _25fdfb31;
    [GLAPI("glPointSize")] internal static __1750c9cb _1750c9cb;
    [GLAPI("glPolygonMode")] internal static __fc1802f1 _fc1802f1;
    [GLAPI("glScissor")] internal static __db7db695 _db7db695;
    [GLAPI("glTexParameterf")] internal static __1404d4c7 _1404d4c7;
    [GLAPI("glTexParameterfv")] internal static __71b46d4a _71b46d4a;
    [GLAPI("glTexParameteri")] internal static __aaa3c8f8 _aaa3c8f8;
    [GLAPI("glTexParameteriv")] internal static __fdde5dcd _fdde5dcd;
    [GLAPI("glTexImage1D")] internal static __e72a31ef _e72a31ef;
    [GLAPI("glTexImage2D")] internal static __2a38e192 _2a38e192;
    [GLAPI("glDrawBuffer")] internal static __92faf100 _92faf100;
    [GLAPI("glClear")] internal static __86fddee7 _86fddee7;
    [GLAPI("glClearColor")] internal static __4db28fb4 _4db28fb4;
    [GLAPI("glClearStencil")] internal static __987b8cdb _987b8cdb;
    [GLAPI("glClearDepth")] internal static __2b9a2760 _2b9a2760;
    [GLAPI("glStencilMask")] internal static __6b99993a _6b99993a;
    [GLAPI("glColorMask")] internal static __bad3c3bb _bad3c3bb;
    [GLAPI("glDepthMask")] internal static __b863c816 _b863c816;
    [GLAPI("glDisable")] internal static __279a6ce9 _279a6ce9;
    [GLAPI("glEnable")] internal static __4ef5196b _4ef5196b;
    [GLAPI("glFinish")] internal static __dee804e7 _dee804e7;
    [GLAPI("glFlush")] internal static __a7bbbd7b _a7bbbd7b;
    [GLAPI("glBlendFunc")] internal static __1fe19d61 _1fe19d61;
    [GLAPI("glLogicOp")] internal static __dcfc3621 _dcfc3621;
    [GLAPI("glStencilFunc")] internal static __a3945d70 _a3945d70;
    [GLAPI("glStencilOp")] internal static __19df7359 _19df7359;
    [GLAPI("glDepthFunc")] internal static __72704436 _72704436;
    [GLAPI("glPixelStoref")] internal static __1a1cb65d _1a1cb65d;
    [GLAPI("glPixelStorei")] internal static __04ece2c5 _04ece2c5;
    [GLAPI("glReadBuffer")] internal static __797b2b28 _797b2b28;
    [GLAPI("glReadPixels")] internal static __c602ffa0 _c602ffa0;
    [GLAPI("glGetBooleanv")] internal static __84065e14 _84065e14;
    [GLAPI("glGetDoublev")] internal static __42ad7abc _42ad7abc;
    [GLAPI("glGetError")] internal static __d9a3d289 _d9a3d289;
    [GLAPI("glGetFloatv")] internal static __d810b16c _d810b16c;
    [GLAPI("glGetIntegerv")] internal static __73f4325c _73f4325c;
    [GLAPI("glGetString")] internal static __798911c2 _798911c2;
    [GLAPI("glGetTexImage")] internal static __c9181268 _c9181268;
    [GLAPI("glGetTexParameterfv")] internal static __d3458f04 _d3458f04;
    [GLAPI("glGetTexParameteriv")] internal static __576dc419 _576dc419;
    [GLAPI("glGetTexLevelParameterfv")] internal static __8466b60f _8466b60f;
    [GLAPI("glGetTexLevelParameteriv")] internal static __f066a9bd _f066a9bd;
    [GLAPI("glIsEnabled")] internal static __a201f5d0 _a201f5d0;
    [GLAPI("glDepthRange")] internal static __f602d7da _f602d7da;
    [GLAPI("glViewport")] internal static __334ad661 _334ad661;
    [GLAPI("glNewList")] internal static __ca5b9962 _ca5b9962;
    [GLAPI("glEndList")] internal static __56575e48 _56575e48;
    [GLAPI("glCallList")] internal static __f3f56df4 _f3f56df4;
    [GLAPI("glCallLists")] internal static __7e943e62 _7e943e62;
    [GLAPI("glDeleteLists")] internal static __4ba9a422 _4ba9a422;
    [GLAPI("glGenLists")] internal static __a0b53545 _a0b53545;
    [GLAPI("glListBase")] internal static __df82023f _df82023f;
    [GLAPI("glBegin")] internal static __b1bba6dd _b1bba6dd;
    [GLAPI("glBitmap")] internal static __1c80402f _1c80402f;
    [GLAPI("glColor3b")] internal static __0cd3e0d7 _0cd3e0d7;
    [GLAPI("glColor3bv")] internal static __cea8f8d5 _cea8f8d5;
    [GLAPI("glColor3d")] internal static __da305434 _da305434;
    [GLAPI("glColor3dv")] internal static __445b25ad _445b25ad;
    [GLAPI("glColor3f")] internal static __6510aac8 _6510aac8;
    [GLAPI("glColor3fv")] internal static __77477849 _77477849;
    [GLAPI("glColor3i")] internal static __0187a683 _0187a683;
    [GLAPI("glColor3iv")] internal static __8fa7dcee _8fa7dcee;
    [GLAPI("glColor3s")] internal static __88dd9efc _88dd9efc;
    [GLAPI("glColor3sv")] internal static __64775026 _64775026;
    [GLAPI("glColor3ub")] internal static __e68eacda _e68eacda;
    [GLAPI("glColor3ubv")] internal static __585eb04d _585eb04d;
    [GLAPI("glColor3ui")] internal static __498a96ab _498a96ab;
    [GLAPI("glColor3uiv")] internal static __17f9684c _17f9684c;
    [GLAPI("glColor3us")] internal static __d2bdf126 _d2bdf126;
    [GLAPI("glColor3usv")] internal static __644c855b _644c855b;
    [GLAPI("glColor4b")] internal static __f818f909 _f818f909;
    [GLAPI("glColor4bv")] internal static __e997005a _e997005a;
    [GLAPI("glColor4d")] internal static __d0b0e935 _d0b0e935;
    [GLAPI("glColor4dv")] internal static __df24cea1 _df24cea1;
    [GLAPI("glColor4f")] internal static __debce663 _debce663;
    [GLAPI("glColor4fv")] internal static __7485c93e _7485c93e;
    [GLAPI("glColor4i")] internal static __655c6548 _655c6548;
    [GLAPI("glColor4iv")] internal static __caa13765 _caa13765;
    [GLAPI("glColor4s")] internal static __cb8ec162 _cb8ec162;
    [GLAPI("glColor4sv")] internal static __275f8d71 _275f8d71;
    [GLAPI("glColor4ub")] internal static __fb48cc9a _fb48cc9a;
    [GLAPI("glColor4ubv")] internal static __9bede176 _9bede176;
    [GLAPI("glColor4ui")] internal static __d85ce9f0 _d85ce9f0;
    [GLAPI("glColor4uiv")] internal static __def35f14 _def35f14;
    [GLAPI("glColor4us")] internal static __cc57831b _cc57831b;
    [GLAPI("glColor4usv")] internal static __8784f7c2 _8784f7c2;
    [GLAPI("glEdgeFlag")] internal static __a4d3b895 _a4d3b895;
    [GLAPI("glEdgeFlagv")] internal static __2654b995 _2654b995;
    [GLAPI("glEnd")] internal static __861f3bc7 _861f3bc7;
    [GLAPI("glIndexd")] internal static __8ffc640c _8ffc640c;
    [GLAPI("glIndexdv")] internal static __e10b7a72 _e10b7a72;
    [GLAPI("glIndexf")] internal static __3c20e00c _3c20e00c;
    [GLAPI("glIndexfv")] internal static __6c3470e3 _6c3470e3;
    [GLAPI("glIndexi")] internal static __a8ca9879 _a8ca9879;
    [GLAPI("glIndexiv")] internal static __faee0a10 _faee0a10;
    [GLAPI("glIndexs")] internal static __87531cfe _87531cfe;
    [GLAPI("glIndexsv")] internal static __f52b2906 _f52b2906;
    [GLAPI("glNormal3b")] internal static __35a38b44 _35a38b44;
    [GLAPI("glNormal3bv")] internal static __8c5b2561 _8c5b2561;
    [GLAPI("glNormal3d")] internal static __0fdee60b _0fdee60b;
    [GLAPI("glNormal3dv")] internal static __1a87f21a _1a87f21a;
    [GLAPI("glNormal3f")] internal static __a62b80db _a62b80db;
    [GLAPI("glNormal3fv")] internal static __6dc131f8 _6dc131f8;
    [GLAPI("glNormal3i")] internal static __60f77136 _60f77136;
    [GLAPI("glNormal3iv")] internal static __e1331e80 _e1331e80;
    [GLAPI("glNormal3s")] internal static __53e4e62b _53e4e62b;
    [GLAPI("glNormal3sv")] internal static __0237630f _0237630f;
    [GLAPI("glRasterPos2d")] internal static __e34d4aff _e34d4aff;
    [GLAPI("glRasterPos2dv")] internal static __8bc8b318 _8bc8b318;
    [GLAPI("glRasterPos2f")] internal static __21f734c7 _21f734c7;
    [GLAPI("glRasterPos2fv")] internal static __14b23ad4 _14b23ad4;
    [GLAPI("glRasterPos2i")] internal static __ecf9625f _ecf9625f;
    [GLAPI("glRasterPos2iv")] internal static __4281b06d _4281b06d;
    [GLAPI("glRasterPos2s")] internal static __b61f2b73 _b61f2b73;
    [GLAPI("glRasterPos2sv")] internal static __8b02b215 _8b02b215;
    [GLAPI("glRasterPos3d")] internal static __dd912ffd _dd912ffd;
    [GLAPI("glRasterPos3dv")] internal static __26420867 _26420867;
    [GLAPI("glRasterPos3f")] internal static __60100c24 _60100c24;
    [GLAPI("glRasterPos3fv")] internal static __398c80e1 _398c80e1;
    [GLAPI("glRasterPos3i")] internal static __04b149a6 _04b149a6;
    [GLAPI("glRasterPos3iv")] internal static __7d11be0a _7d11be0a;
    [GLAPI("glRasterPos3s")] internal static __795d2e9d _795d2e9d;
    [GLAPI("glRasterPos3sv")] internal static __269f69be _269f69be;
    [GLAPI("glRasterPos4d")] internal static __22a9bebf _22a9bebf;
    [GLAPI("glRasterPos4dv")] internal static __c10bb15b _c10bb15b;
    [GLAPI("glRasterPos4f")] internal static __b82e0de2 _b82e0de2;
    [GLAPI("glRasterPos4fv")] internal static __36cad1d6 _36cad1d6;
    [GLAPI("glRasterPos4i")] internal static __2904138b _2904138b;
    [GLAPI("glRasterPos4iv")] internal static __b80b1981 _b80b1981;
    [GLAPI("glRasterPos4s")] internal static __837698cc _837698cc;
    [GLAPI("glRasterPos4sv")] internal static __e986a609 _e986a609;
    [GLAPI("glRectd")] internal static __cfbabaea _cfbabaea;
    [GLAPI("glRectdv")] internal static __18dff932 _18dff932;
    [GLAPI("glRectf")] internal static __3d8b727f _3d8b727f;
    [GLAPI("glRectfv")] internal static __c45bbd82 _c45bbd82;
    [GLAPI("glRecti")] internal static __e0afb420 _e0afb420;
    [GLAPI("glRectiv")] internal static __cbcdaa71 _cbcdaa71;
    [GLAPI("glRects")] internal static __6aea02f0 _6aea02f0;
    [GLAPI("glRectsv")] internal static __0dde7f65 _0dde7f65;
    [GLAPI("glTexCoord1d")] internal static __d45a95a5 _d45a95a5;
    [GLAPI("glTexCoord1dv")] internal static __7357c9df _7357c9df;
    [GLAPI("glTexCoord1f")] internal static __6b724f36 _6b724f36;
    [GLAPI("glTexCoord1fv")] internal static __aa5a8f0d _aa5a8f0d;
    [GLAPI("glTexCoord1i")] internal static __8fbd9be5 _8fbd9be5;
    [GLAPI("glTexCoord1iv")] internal static __dcb9e889 _dcb9e889;
    [GLAPI("glTexCoord1s")] internal static __20e11541 _20e11541;
    [GLAPI("glTexCoord1sv")] internal static __737ec49b _737ec49b;
    [GLAPI("glTexCoord2d")] internal static __ccbff864 _ccbff864;
    [GLAPI("glTexCoord2dv")] internal static __762750df _762750df;
    [GLAPI("glTexCoord2f")] internal static __1a4967fe _1a4967fe;
    [GLAPI("glTexCoord2fv")] internal static __6711160d _6711160d;
    [GLAPI("glTexCoord2i")] internal static __7311b6b8 _7311b6b8;
    [GLAPI("glTexCoord2iv")] internal static __7f0de589 _7f0de589;
    [GLAPI("glTexCoord2s")] internal static __f114a9ce _f114a9ce;
    [GLAPI("glTexCoord2sv")] internal static __76354b9b _76354b9b;
    [GLAPI("glTexCoord3d")] internal static __d62d5b5b _d62d5b5b;
    [GLAPI("glTexCoord3dv")] internal static __752761df _752761df;
    [GLAPI("glTexCoord3f")] internal static __5f80c7fe _5f80c7fe;
    [GLAPI("glTexCoord3fv")] internal static __281a270d _281a270d;
    [GLAPI("glTexCoord3i")] internal static __ebebd686 _ebebd686;
    [GLAPI("glTexCoord3iv")] internal static __9e91e589 _9e91e589;
    [GLAPI("glTexCoord3s")] internal static __c04ecc0c _c04ecc0c;
    [GLAPI("glTexCoord3sv")] internal static __753d5c9b _753d5c9b;
    [GLAPI("glTexCoord4d")] internal static __3f4b1e97 _3f4b1e97;
    [GLAPI("glTexCoord4dv")] internal static __7078fcdf _7078fcdf;
    [GLAPI("glTexCoord4f")] internal static __85ea6c47 _85ea6c47;
    [GLAPI("glTexCoord4fv")] internal static __e572c20d _e572c20d;
    [GLAPI("glTexCoord4i")] internal static __942206e6 _942206e6;
    [GLAPI("glTexCoord4iv")] internal static __3946ea89 _3946ea89;
    [GLAPI("glTexCoord4s")] internal static __2625afd4 _2625afd4;
    [GLAPI("glTexCoord4sv")] internal static __7875f79b _7875f79b;
    [GLAPI("glVertex2d")] internal static __e49c1b0e _e49c1b0e;
    [GLAPI("glVertex2dv")] internal static __1ac9e99a _1ac9e99a;
    [GLAPI("glVertex2f")] internal static __74642e62 _74642e62;
    [GLAPI("glVertex2fv")] internal static __430581ee _430581ee;
    [GLAPI("glVertex2i")] internal static __5949e42b _5949e42b;
    [GLAPI("glVertex2iv")] internal static __43970266 _43970266;
    [GLAPI("glVertex2s")] internal static __0bd961f7 _0bd961f7;
    [GLAPI("glVertex2sv")] internal static __3223327b _3223327b;
    [GLAPI("glVertex3d")] internal static __3a040d99 _3a040d99;
    [GLAPI("glVertex3dv")] internal static __19c9fa9a _19c9fa9a;
    [GLAPI("glVertex3f")] internal static __9d8745cf _9d8745cf;
    [GLAPI("glVertex3fv")] internal static __040e92ee _040e92ee;
    [GLAPI("glVertex3i")] internal static __5998251c _5998251c;
    [GLAPI("glVertex3iv")] internal static __621b0366 _621b0366;
    [GLAPI("glVertex3s")] internal static __723c06ba _723c06ba;
    [GLAPI("glVertex3sv")] internal static __312b437b _312b437b;
    [GLAPI("glVertex4d")] internal static __c7b54414 _c7b54414;
    [GLAPI("glVertex4dv")] internal static __141a969b _141a969b;
    [GLAPI("glVertex4f")] internal static __2902069e _2902069e;
    [GLAPI("glVertex4fv")] internal static __c1662def _c1662def;
    [GLAPI("glVertex4i")] internal static __b0f30bd0 _b0f30bd0;
    [GLAPI("glVertex4iv")] internal static __fdcf0766 _fdcf0766;
    [GLAPI("glVertex4s")] internal static __3294d0b6 _3294d0b6;
    [GLAPI("glVertex4sv")] internal static __3463de7b _3463de7b;
    [GLAPI("glClipPlane")] internal static __d859522f _d859522f;
    [GLAPI("glColorMaterial")] internal static __3bcba941 _3bcba941;
    [GLAPI("glFogf")] internal static __ddce593e _ddce593e;
    [GLAPI("glFogfv")] internal static __aef7e940 _aef7e940;
    [GLAPI("glFogi")] internal static __4908499e _4908499e;
    [GLAPI("glFogiv")] internal static __6a0c3e92 _6a0c3e92;
    [GLAPI("glLightf")] internal static __95e47d11 _95e47d11;
    [GLAPI("glLightfv")] internal static __c4f3a880 _c4f3a880;
    [GLAPI("glLighti")] internal static __190ffbc4 _190ffbc4;
    [GLAPI("glLightiv")] internal static __726d17eb _726d17eb;
    [GLAPI("glLightModelf")] internal static __b278060c _b278060c;
    [GLAPI("glLightModelfv")] internal static __b3260152 _b3260152;
    [GLAPI("glLightModeli")] internal static __6cc17abd _6cc17abd;
    [GLAPI("glLightModeliv")] internal static __5f42a921 _5f42a921;
    [GLAPI("glLineStipple")] internal static __23cee444 _23cee444;
    [GLAPI("glMaterialf")] internal static __bbff97f6 _bbff97f6;
    [GLAPI("glMaterialfv")] internal static __18ebb25a _18ebb25a;
    [GLAPI("glMateriali")] internal static __f388808e _f388808e;
    [GLAPI("glMaterialiv")] internal static __64162f7f _64162f7f;
    [GLAPI("glPolygonStipple")] internal static __246fd5f4 _246fd5f4;
    [GLAPI("glShadeModel")] internal static __40da144a _40da144a;
    [GLAPI("glTexEnvf")] internal static __1cfdcba9 _1cfdcba9;
    [GLAPI("glTexEnvfv")] internal static __019eb7a5 _019eb7a5;
    [GLAPI("glTexEnvi")] internal static __52519b59 _52519b59;
    [GLAPI("glTexEnviv")] internal static __b5c91783 _b5c91783;
    [GLAPI("glTexGend")] internal static __2ad8eaf0 _2ad8eaf0;
    [GLAPI("glTexGendv")] internal static __53ae20f3 _53ae20f3;
    [GLAPI("glTexGenf")] internal static __09ffcffe _09ffcffe;
    [GLAPI("glTexGenfv")] internal static __7c4a8236 _7c4a8236;
    [GLAPI("glTexGeni")] internal static __9575e3ee _9575e3ee;
    [GLAPI("glTexGeniv")] internal static __e2a3cfc7 _e2a3cfc7;
    [GLAPI("glFeedbackBuffer")] internal static __c07b5e08 _c07b5e08;
    [GLAPI("glSelectBuffer")] internal static __77dde102 _77dde102;
    [GLAPI("glRenderMode")] internal static __2387af4a _2387af4a;
    [GLAPI("glInitNames")] internal static __65cffbae _65cffbae;
    [GLAPI("glLoadName")] internal static __affed860 _affed860;
    [GLAPI("glPassThrough")] internal static __02490811 _02490811;
    [GLAPI("glPopName")] internal static __9f9c5f4c _9f9c5f4c;
    [GLAPI("glPushName")] internal static __c7ff8379 _c7ff8379;
    [GLAPI("glClearAccum")] internal static __95eee1a8 _95eee1a8;
    [GLAPI("glClearIndex")] internal static __1b048ed3 _1b048ed3;
    [GLAPI("glIndexMask")] internal static __4781d9a1 _4781d9a1;
    [GLAPI("glAccum")] internal static __1c15bdc4 _1c15bdc4;
    [GLAPI("glPopAttrib")] internal static __489c9d7d _489c9d7d;
    [GLAPI("glPushAttrib")] internal static __db36041e _db36041e;
    [GLAPI("glMap1d")] internal static __337b9b25 _337b9b25;
    [GLAPI("glMap1f")] internal static __7263f26d _7263f26d;
    [GLAPI("glMap2d")] internal static __08c95560 _08c95560;
    [GLAPI("glMap2f")] internal static __7bf18b7b _7bf18b7b;
    [GLAPI("glMapGrid1d")] internal static __b965fa86 _b965fa86;
    [GLAPI("glMapGrid1f")] internal static __9f979e20 _9f979e20;
    [GLAPI("glMapGrid2d")] internal static __32a15f26 _32a15f26;
    [GLAPI("glMapGrid2f")] internal static __620f8096 _620f8096;
    [GLAPI("glEvalCoord1d")] internal static __75d7dc91 _75d7dc91;
    [GLAPI("glEvalCoord1dv")] internal static __e7c3d5b5 _e7c3d5b5;
    [GLAPI("glEvalCoord1f")] internal static __faec20e0 _faec20e0;
    [GLAPI("glEvalCoord1fv")] internal static __aa0cee40 _aa0cee40;
    [GLAPI("glEvalCoord2d")] internal static __1576bacd _1576bacd;
    [GLAPI("glEvalCoord2dv")] internal static __4c9fcd77 _4c9fcd77;
    [GLAPI("glEvalCoord2f")] internal static __b78e37fa _b78e37fa;
    [GLAPI("glEvalCoord2fv")] internal static __4f3e1210 _4f3e1210;
    [GLAPI("glEvalMesh1")] internal static __39c162c6 _39c162c6;
    [GLAPI("glEvalPoint1")] internal static __aa197ab7 _aa197ab7;
    [GLAPI("glEvalMesh2")] internal static __09332c3d _09332c3d;
    [GLAPI("glEvalPoint2")] internal static __5a98516c _5a98516c;
    [GLAPI("glAlphaFunc")] internal static __028c9a04 _028c9a04;
    [GLAPI("glPixelZoom")] internal static __1536aa22 _1536aa22;
    [GLAPI("glPixelTransferf")] internal static __527c14e0 _527c14e0;
    [GLAPI("glPixelTransferi")] internal static __5ce387c1 _5ce387c1;
    [GLAPI("glPixelMapfv")] internal static __9b074d83 _9b074d83;
    [GLAPI("glPixelMapuiv")] internal static __8324eaaa _8324eaaa;
    [GLAPI("glPixelMapusv")] internal static __4e92517a _4e92517a;
    [GLAPI("glCopyPixels")] internal static __db49418a _db49418a;
    [GLAPI("glDrawPixels")] internal static __4dcbe34b _4dcbe34b;
    [GLAPI("glGetClipPlane")] internal static __4692fc25 _4692fc25;
    [GLAPI("glGetLightfv")] internal static __669f20fd _669f20fd;
    [GLAPI("glGetLightiv")] internal static __c8b6feb9 _c8b6feb9;
    [GLAPI("glGetMapdv")] internal static __af44dfb9 _af44dfb9;
    [GLAPI("glGetMapfv")] internal static __8e4d1277 _8e4d1277;
    [GLAPI("glGetMapiv")] internal static __ba6cd407 _ba6cd407;
    [GLAPI("glGetMaterialfv")] internal static __3e37f3f4 _3e37f3f4;
    [GLAPI("glGetMaterialiv")] internal static __8249da76 _8249da76;
    [GLAPI("glGetPixelMapfv")] internal static __37232ea7 _37232ea7;
    [GLAPI("glGetPixelMapuiv")] internal static __cf6364c6 _cf6364c6;
    [GLAPI("glGetPixelMapusv")] internal static __3807c24f _3807c24f;
    [GLAPI("glGetPolygonStipple")] internal static __ae2cfa54 _ae2cfa54;
    [GLAPI("glGetTexEnvfv")] internal static __77f98f04 _77f98f04;
    [GLAPI("glGetTexEnviv")] internal static __b350ea0d _b350ea0d;
    [GLAPI("glGetTexGendv")] internal static __6d944f58 _6d944f58;
    [GLAPI("glGetTexGenfv")] internal static __86c87c31 _86c87c31;
    [GLAPI("glGetTexGeniv")] internal static __f801871f _f801871f;
    [GLAPI("glIsList")] internal static __33becbea _33becbea;
    [GLAPI("glFrustum")] internal static __73fb0eda _73fb0eda;
    [GLAPI("glLoadIdentity")] internal static __1b5ecb65 _1b5ecb65;
    [GLAPI("glLoadMatrixf")] internal static __bd37620a _bd37620a;
    [GLAPI("glLoadMatrixd")] internal static __f07f2ee3 _f07f2ee3;
    [GLAPI("glMatrixMode")] internal static __243b542a _243b542a;
    [GLAPI("glMultMatrixf")] internal static __4be38bd2 _4be38bd2;
    [GLAPI("glMultMatrixd")] internal static __feb81336 _feb81336;
    [GLAPI("glOrtho")] internal static __3b902c5c _3b902c5c;
    [GLAPI("glPopMatrix")] internal static __b7330842 _b7330842;
    [GLAPI("glPushMatrix")] internal static __4c4cebb6 _4c4cebb6;
    [GLAPI("glRotated")] internal static __0cc0ada5 _0cc0ada5;
    [GLAPI("glRotatef")] internal static __6e803879 _6e803879;
    [GLAPI("glScaled")] internal static __3dfce7c4 _3dfce7c4;
    [GLAPI("glScalef")] internal static __56360ea2 _56360ea2;
    [GLAPI("glTranslated")] internal static __6b320264 _6b320264;
    [GLAPI("glTranslatef")] internal static __4ecdb9da _4ecdb9da;
    [GLAPI("glDrawArrays")] internal static __01d8be9e _01d8be9e;
    [GLAPI("glDrawElements")] internal static __3434f3d5 _3434f3d5;
    [GLAPI("glGetPointerv")] internal static __893b8618 _893b8618;
    [GLAPI("glPolygonOffset")] internal static __cafc6a15 _cafc6a15;
    [GLAPI("glCopyTexImage1D")] internal static __7425775f _7425775f;
    [GLAPI("glCopyTexImage2D")] internal static __05fa3b3d _05fa3b3d;
    [GLAPI("glCopyTexSubImage1D")] internal static __c953c099 _c953c099;
    [GLAPI("glCopyTexSubImage2D")] internal static __b5f2e5b5 _b5f2e5b5;
    [GLAPI("glTexSubImage1D")] internal static __d109dba5 _d109dba5;
    [GLAPI("glTexSubImage2D")] internal static __65dfd7a5 _65dfd7a5;
    [GLAPI("glBindTexture")] internal static __dbafbeec _dbafbeec;
    [GLAPI("glDeleteTextures")] internal static __6d2ff7b1 _6d2ff7b1;
    [GLAPI("glGenTextures")] internal static __48a443e4 _48a443e4;
    [GLAPI("glIsTexture")] internal static __3f0e63e4 _3f0e63e4;
    [GLAPI("glArrayElement")] internal static __d6b03661 _d6b03661;
    [GLAPI("glColorPointer")] internal static __7431f153 _7431f153;
    [GLAPI("glDisableClientState")] internal static __8e06463d _8e06463d;
    [GLAPI("glEdgeFlagPointer")] internal static __b468ef7c _b468ef7c;
    [GLAPI("glEnableClientState")] internal static __1376a10b _1376a10b;
    [GLAPI("glIndexPointer")] internal static __19f25888 _19f25888;
    [GLAPI("glInterleavedArrays")] internal static __ce62da50 _ce62da50;
    [GLAPI("glNormalPointer")] internal static __d8589b45 _d8589b45;
    [GLAPI("glTexCoordPointer")] internal static __c5ed1c61 _c5ed1c61;
    [GLAPI("glVertexPointer")] internal static __6902b086 _6902b086;
    [GLAPI("glAreTexturesResident")] internal static __c5daf0ec _c5daf0ec;
    [GLAPI("glPrioritizeTextures")] internal static __79045508 _79045508;
    [GLAPI("glIndexub")] internal static __13dd9132 _13dd9132;
    [GLAPI("glIndexubv")] internal static __71eb817e _71eb817e;
    [GLAPI("glPopClientAttrib")] internal static __317e3149 _317e3149;
    [GLAPI("glPushClientAttrib")] internal static __fe512606 _fe512606;
    #endregion

    #region API
    public static void glCullFace(uint mode)
        => _e950395c(mode);
    public static void glFrontFace(uint mode)
        => _362ea5aa(mode);
    public static void glHint(uint target, uint mode)
        => _2aa1c384(target, mode);
    public static void glLineWidth(float width)
        => _25fdfb31(width);
    public static void glPointSize(float size)
        => _1750c9cb(size);
    public static void glPolygonMode(uint face, uint mode)
        => _fc1802f1(face, mode);
    public static void glScissor(int x, int y, int width, int height)
        => _db7db695(x, y, width, height);
    public static void glTexParameterf(uint target, uint pname, float param)
        => _1404d4c7(target, pname, param);
    public static void glTexParameterfv(uint target, uint pname, float* @params)
        => _71b46d4a(target, pname, @params);
    public static void glTexParameteri(uint target, uint pname, int param)
        => _aaa3c8f8(target, pname, param);
    public static void glTexParameteriv(uint target, uint pname, int* @params)
        => _fdde5dcd(target, pname, @params);
    public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels)
        => _e72a31ef(target, level, internalformat, width, border, format, type, pixels);
    public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels)
        => _2a38e192(target, level, internalformat, width, height, border, format, type, pixels);
    public static void glDrawBuffer(uint buf)
        => _92faf100(buf);
    public static void glClear(uint mask)
        => _86fddee7(mask);
    public static void glClearColor(float red, float green, float blue, float alpha)
        => _4db28fb4(red, green, blue, alpha);
    public static void glClearStencil(int s)
        => _987b8cdb(s);
    public static void glClearDepth(double depth)
        => _2b9a2760(depth);
    public static void glStencilMask(uint mask)
        => _6b99993a(mask);
    public static void glColorMask(bool red, bool green, bool blue, bool alpha)
        => _bad3c3bb(red, green, blue, alpha);
    public static void glDepthMask(bool flag)
        => _b863c816(flag);
    public static void glDisable(uint cap)
        => _279a6ce9(cap);
    public static void glEnable(uint cap)
        => _4ef5196b(cap);
    public static void glFinish()
        => _dee804e7();
    public static void glFlush()
        => _a7bbbd7b();
    public static void glBlendFunc(uint sfactor, uint dfactor)
        => _1fe19d61(sfactor, dfactor);
    public static void glLogicOp(uint opcode)
        => _dcfc3621(opcode);
    public static void glStencilFunc(uint func, int @ref, uint mask)
        => _a3945d70(func, @ref, mask);
    public static void glStencilOp(uint fail, uint zfail, uint zpass)
        => _19df7359(fail, zfail, zpass);
    public static void glDepthFunc(uint func)
        => _72704436(func);
    public static void glPixelStoref(uint pname, float param)
        => _1a1cb65d(pname, param);
    public static void glPixelStorei(uint pname, int param)
        => _04ece2c5(pname, param);
    public static void glReadBuffer(uint src)
        => _797b2b28(src);
    public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels)
        => _c602ffa0(x, y, width, height, format, type, pixels);
    public static void glGetBooleanv(uint pname, bool* data)
        => _84065e14(pname, data);
    public static void glGetDoublev(uint pname, double* data)
        => _42ad7abc(pname, data);
    public static uint glGetError()
        => _d9a3d289();
    public static void glGetFloatv(uint pname, float* data)
        => _d810b16c(pname, data);
    public static void glGetIntegerv(uint pname, int* data)
        => _73f4325c(pname, data);
    public static byte* glGetString(uint name)
        => _798911c2(name);
    public static void glGetTexImage(uint target, int level, uint format, uint type, void* pixels)
        => _c9181268(target, level, format, type, pixels);
    public static void glGetTexParameterfv(uint target, uint pname, float* @params)
        => _d3458f04(target, pname, @params);
    public static void glGetTexParameteriv(uint target, uint pname, int* @params)
        => _576dc419(target, pname, @params);
    public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params)
        => _8466b60f(target, level, pname, @params);
    public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params)
        => _f066a9bd(target, level, pname, @params);
    public static bool glIsEnabled(uint cap)
        => _a201f5d0(cap);
    public static void glDepthRange(double near, double far)
        => _f602d7da(near, far);
    public static void glViewport(int x, int y, int width, int height)
        => _334ad661(x, y, width, height);
    public static void glNewList(uint list, uint mode)
        => _ca5b9962(list, mode);
    public static void glEndList()
        => _56575e48();
    public static void glCallList(uint list)
        => _f3f56df4(list);
    public static void glCallLists(int n, uint type, void* lists)
        => _7e943e62(n, type, lists);
    public static void glDeleteLists(uint list, int range)
        => _4ba9a422(list, range);
    public static uint glGenLists(int range)
        => _a0b53545(range);
    public static void glListBase(uint @base)
        => _df82023f(@base);
    public static void glBegin(uint mode)
        => _b1bba6dd(mode);
    public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap)
        => _1c80402f(width, height, xorig, yorig, xmove, ymove, bitmap);
    public static void glColor3b(sbyte red, sbyte green, sbyte blue)
        => _0cd3e0d7(red, green, blue);
    public static void glColor3bv(sbyte* v)
        => _cea8f8d5(v);
    public static void glColor3d(double red, double green, double blue)
        => _da305434(red, green, blue);
    public static void glColor3dv(double* v)
        => _445b25ad(v);
    public static void glColor3f(float red, float green, float blue)
        => _6510aac8(red, green, blue);
    public static void glColor3fv(float* v)
        => _77477849(v);
    public static void glColor3i(int red, int green, int blue)
        => _0187a683(red, green, blue);
    public static void glColor3iv(int* v)
        => _8fa7dcee(v);
    public static void glColor3s(short red, short green, short blue)
        => _88dd9efc(red, green, blue);
    public static void glColor3sv(short* v)
        => _64775026(v);
    public static void glColor3ub(byte red, byte green, byte blue)
        => _e68eacda(red, green, blue);
    public static void glColor3ubv(byte* v)
        => _585eb04d(v);
    public static void glColor3ui(uint red, uint green, uint blue)
        => _498a96ab(red, green, blue);
    public static void glColor3uiv(uint* v)
        => _17f9684c(v);
    public static void glColor3us(ushort red, ushort green, ushort blue)
        => _d2bdf126(red, green, blue);
    public static void glColor3usv(ushort* v)
        => _644c855b(v);
    public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha)
        => _f818f909(red, green, blue, alpha);
    public static void glColor4bv(sbyte* v)
        => _e997005a(v);
    public static void glColor4d(double red, double green, double blue, double alpha)
        => _d0b0e935(red, green, blue, alpha);
    public static void glColor4dv(double* v)
        => _df24cea1(v);
    public static void glColor4f(float red, float green, float blue, float alpha)
        => _debce663(red, green, blue, alpha);
    public static void glColor4fv(float* v)
        => _7485c93e(v);
    public static void glColor4i(int red, int green, int blue, int alpha)
        => _655c6548(red, green, blue, alpha);
    public static void glColor4iv(int* v)
        => _caa13765(v);
    public static void glColor4s(short red, short green, short blue, short alpha)
        => _cb8ec162(red, green, blue, alpha);
    public static void glColor4sv(short* v)
        => _275f8d71(v);
    public static void glColor4ub(byte red, byte green, byte blue, byte alpha)
        => _fb48cc9a(red, green, blue, alpha);
    public static void glColor4ubv(byte* v)
        => _9bede176(v);
    public static void glColor4ui(uint red, uint green, uint blue, uint alpha)
        => _d85ce9f0(red, green, blue, alpha);
    public static void glColor4uiv(uint* v)
        => _def35f14(v);
    public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha)
        => _cc57831b(red, green, blue, alpha);
    public static void glColor4usv(ushort* v)
        => _8784f7c2(v);
    public static void glEdgeFlag(bool flag)
        => _a4d3b895(flag);
    public static void glEdgeFlagv(bool* flag)
        => _2654b995(flag);
    public static void glEnd()
        => _861f3bc7();
    public static void glIndexd(double c)
        => _8ffc640c(c);
    public static void glIndexdv(double* c)
        => _e10b7a72(c);
    public static void glIndexf(float c)
        => _3c20e00c(c);
    public static void glIndexfv(float* c)
        => _6c3470e3(c);
    public static void glIndexi(int c)
        => _a8ca9879(c);
    public static void glIndexiv(int* c)
        => _faee0a10(c);
    public static void glIndexs(short c)
        => _87531cfe(c);
    public static void glIndexsv(short* c)
        => _f52b2906(c);
    public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz)
        => _35a38b44(nx, ny, nz);
    public static void glNormal3bv(sbyte* v)
        => _8c5b2561(v);
    public static void glNormal3d(double nx, double ny, double nz)
        => _0fdee60b(nx, ny, nz);
    public static void glNormal3dv(double* v)
        => _1a87f21a(v);
    public static void glNormal3f(float nx, float ny, float nz)
        => _a62b80db(nx, ny, nz);
    public static void glNormal3fv(float* v)
        => _6dc131f8(v);
    public static void glNormal3i(int nx, int ny, int nz)
        => _60f77136(nx, ny, nz);
    public static void glNormal3iv(int* v)
        => _e1331e80(v);
    public static void glNormal3s(short nx, short ny, short nz)
        => _53e4e62b(nx, ny, nz);
    public static void glNormal3sv(short* v)
        => _0237630f(v);
    public static void glRasterPos2d(double x, double y)
        => _e34d4aff(x, y);
    public static void glRasterPos2dv(double* v)
        => _8bc8b318(v);
    public static void glRasterPos2f(float x, float y)
        => _21f734c7(x, y);
    public static void glRasterPos2fv(float* v)
        => _14b23ad4(v);
    public static void glRasterPos2i(int x, int y)
        => _ecf9625f(x, y);
    public static void glRasterPos2iv(int* v)
        => _4281b06d(v);
    public static void glRasterPos2s(short x, short y)
        => _b61f2b73(x, y);
    public static void glRasterPos2sv(short* v)
        => _8b02b215(v);
    public static void glRasterPos3d(double x, double y, double z)
        => _dd912ffd(x, y, z);
    public static void glRasterPos3dv(double* v)
        => _26420867(v);
    public static void glRasterPos3f(float x, float y, float z)
        => _60100c24(x, y, z);
    public static void glRasterPos3fv(float* v)
        => _398c80e1(v);
    public static void glRasterPos3i(int x, int y, int z)
        => _04b149a6(x, y, z);
    public static void glRasterPos3iv(int* v)
        => _7d11be0a(v);
    public static void glRasterPos3s(short x, short y, short z)
        => _795d2e9d(x, y, z);
    public static void glRasterPos3sv(short* v)
        => _269f69be(v);
    public static void glRasterPos4d(double x, double y, double z, double w)
        => _22a9bebf(x, y, z, w);
    public static void glRasterPos4dv(double* v)
        => _c10bb15b(v);
    public static void glRasterPos4f(float x, float y, float z, float w)
        => _b82e0de2(x, y, z, w);
    public static void glRasterPos4fv(float* v)
        => _36cad1d6(v);
    public static void glRasterPos4i(int x, int y, int z, int w)
        => _2904138b(x, y, z, w);
    public static void glRasterPos4iv(int* v)
        => _b80b1981(v);
    public static void glRasterPos4s(short x, short y, short z, short w)
        => _837698cc(x, y, z, w);
    public static void glRasterPos4sv(short* v)
        => _e986a609(v);
    public static void glRectd(double x1, double y1, double x2, double y2)
        => _cfbabaea(x1, y1, x2, y2);
    public static void glRectdv(double* v1, double* v2)
        => _18dff932(v1, v2);
    public static void glRectf(float x1, float y1, float x2, float y2)
        => _3d8b727f(x1, y1, x2, y2);
    public static void glRectfv(float* v1, float* v2)
        => _c45bbd82(v1, v2);
    public static void glRecti(int x1, int y1, int x2, int y2)
        => _e0afb420(x1, y1, x2, y2);
    public static void glRectiv(int* v1, int* v2)
        => _cbcdaa71(v1, v2);
    public static void glRects(short x1, short y1, short x2, short y2)
        => _6aea02f0(x1, y1, x2, y2);
    public static void glRectsv(short* v1, short* v2)
        => _0dde7f65(v1, v2);
    public static void glTexCoord1d(double s)
        => _d45a95a5(s);
    public static void glTexCoord1dv(double* v)
        => _7357c9df(v);
    public static void glTexCoord1f(float s)
        => _6b724f36(s);
    public static void glTexCoord1fv(float* v)
        => _aa5a8f0d(v);
    public static void glTexCoord1i(int s)
        => _8fbd9be5(s);
    public static void glTexCoord1iv(int* v)
        => _dcb9e889(v);
    public static void glTexCoord1s(short s)
        => _20e11541(s);
    public static void glTexCoord1sv(short* v)
        => _737ec49b(v);
    public static void glTexCoord2d(double s, double t)
        => _ccbff864(s, t);
    public static void glTexCoord2dv(double* v)
        => _762750df(v);
    public static void glTexCoord2f(float s, float t)
        => _1a4967fe(s, t);
    public static void glTexCoord2fv(float* v)
        => _6711160d(v);
    public static void glTexCoord2i(int s, int t)
        => _7311b6b8(s, t);
    public static void glTexCoord2iv(int* v)
        => _7f0de589(v);
    public static void glTexCoord2s(short s, short t)
        => _f114a9ce(s, t);
    public static void glTexCoord2sv(short* v)
        => _76354b9b(v);
    public static void glTexCoord3d(double s, double t, double r)
        => _d62d5b5b(s, t, r);
    public static void glTexCoord3dv(double* v)
        => _752761df(v);
    public static void glTexCoord3f(float s, float t, float r)
        => _5f80c7fe(s, t, r);
    public static void glTexCoord3fv(float* v)
        => _281a270d(v);
    public static void glTexCoord3i(int s, int t, int r)
        => _ebebd686(s, t, r);
    public static void glTexCoord3iv(int* v)
        => _9e91e589(v);
    public static void glTexCoord3s(short s, short t, short r)
        => _c04ecc0c(s, t, r);
    public static void glTexCoord3sv(short* v)
        => _753d5c9b(v);
    public static void glTexCoord4d(double s, double t, double r, double q)
        => _3f4b1e97(s, t, r, q);
    public static void glTexCoord4dv(double* v)
        => _7078fcdf(v);
    public static void glTexCoord4f(float s, float t, float r, float q)
        => _85ea6c47(s, t, r, q);
    public static void glTexCoord4fv(float* v)
        => _e572c20d(v);
    public static void glTexCoord4i(int s, int t, int r, int q)
        => _942206e6(s, t, r, q);
    public static void glTexCoord4iv(int* v)
        => _3946ea89(v);
    public static void glTexCoord4s(short s, short t, short r, short q)
        => _2625afd4(s, t, r, q);
    public static void glTexCoord4sv(short* v)
        => _7875f79b(v);
    public static void glVertex2d(double x, double y)
        => _e49c1b0e(x, y);
    public static void glVertex2dv(double* v)
        => _1ac9e99a(v);
    public static void glVertex2f(float x, float y)
        => _74642e62(x, y);
    public static void glVertex2fv(float* v)
        => _430581ee(v);
    public static void glVertex2i(int x, int y)
        => _5949e42b(x, y);
    public static void glVertex2iv(int* v)
        => _43970266(v);
    public static void glVertex2s(short x, short y)
        => _0bd961f7(x, y);
    public static void glVertex2sv(short* v)
        => _3223327b(v);
    public static void glVertex3d(double x, double y, double z)
        => _3a040d99(x, y, z);
    public static void glVertex3dv(double* v)
        => _19c9fa9a(v);
    public static void glVertex3f(float x, float y, float z)
        => _9d8745cf(x, y, z);
    public static void glVertex3fv(float* v)
        => _040e92ee(v);
    public static void glVertex3i(int x, int y, int z)
        => _5998251c(x, y, z);
    public static void glVertex3iv(int* v)
        => _621b0366(v);
    public static void glVertex3s(short x, short y, short z)
        => _723c06ba(x, y, z);
    public static void glVertex3sv(short* v)
        => _312b437b(v);
    public static void glVertex4d(double x, double y, double z, double w)
        => _c7b54414(x, y, z, w);
    public static void glVertex4dv(double* v)
        => _141a969b(v);
    public static void glVertex4f(float x, float y, float z, float w)
        => _2902069e(x, y, z, w);
    public static void glVertex4fv(float* v)
        => _c1662def(v);
    public static void glVertex4i(int x, int y, int z, int w)
        => _b0f30bd0(x, y, z, w);
    public static void glVertex4iv(int* v)
        => _fdcf0766(v);
    public static void glVertex4s(short x, short y, short z, short w)
        => _3294d0b6(x, y, z, w);
    public static void glVertex4sv(short* v)
        => _3463de7b(v);
    public static void glClipPlane(uint plane, double* equation)
        => _d859522f(plane, equation);
    public static void glColorMaterial(uint face, uint mode)
        => _3bcba941(face, mode);
    public static void glFogf(uint pname, float param)
        => _ddce593e(pname, param);
    public static void glFogfv(uint pname, float* @params)
        => _aef7e940(pname, @params);
    public static void glFogi(uint pname, int param)
        => _4908499e(pname, param);
    public static void glFogiv(uint pname, int* @params)
        => _6a0c3e92(pname, @params);
    public static void glLightf(uint light, uint pname, float param)
        => _95e47d11(light, pname, param);
    public static void glLightfv(uint light, uint pname, float* @params)
        => _c4f3a880(light, pname, @params);
    public static void glLighti(uint light, uint pname, int param)
        => _190ffbc4(light, pname, param);
    public static void glLightiv(uint light, uint pname, int* @params)
        => _726d17eb(light, pname, @params);
    public static void glLightModelf(uint pname, float param)
        => _b278060c(pname, param);
    public static void glLightModelfv(uint pname, float* @params)
        => _b3260152(pname, @params);
    public static void glLightModeli(uint pname, int param)
        => _6cc17abd(pname, param);
    public static void glLightModeliv(uint pname, int* @params)
        => _5f42a921(pname, @params);
    public static void glLineStipple(int factor, ushort pattern)
        => _23cee444(factor, pattern);
    public static void glMaterialf(uint face, uint pname, float param)
        => _bbff97f6(face, pname, param);
    public static void glMaterialfv(uint face, uint pname, float* @params)
        => _18ebb25a(face, pname, @params);
    public static void glMateriali(uint face, uint pname, int param)
        => _f388808e(face, pname, param);
    public static void glMaterialiv(uint face, uint pname, int* @params)
        => _64162f7f(face, pname, @params);
    public static void glPolygonStipple(byte* mask)
        => _246fd5f4(mask);
    public static void glShadeModel(uint mode)
        => _40da144a(mode);
    public static void glTexEnvf(uint target, uint pname, float param)
        => _1cfdcba9(target, pname, param);
    public static void glTexEnvfv(uint target, uint pname, float* @params)
        => _019eb7a5(target, pname, @params);
    public static void glTexEnvi(uint target, uint pname, int param)
        => _52519b59(target, pname, param);
    public static void glTexEnviv(uint target, uint pname, int* @params)
        => _b5c91783(target, pname, @params);
    public static void glTexGend(uint coord, uint pname, double param)
        => _2ad8eaf0(coord, pname, param);
    public static void glTexGendv(uint coord, uint pname, double* @params)
        => _53ae20f3(coord, pname, @params);
    public static void glTexGenf(uint coord, uint pname, float param)
        => _09ffcffe(coord, pname, param);
    public static void glTexGenfv(uint coord, uint pname, float* @params)
        => _7c4a8236(coord, pname, @params);
    public static void glTexGeni(uint coord, uint pname, int param)
        => _9575e3ee(coord, pname, param);
    public static void glTexGeniv(uint coord, uint pname, int* @params)
        => _e2a3cfc7(coord, pname, @params);
    public static void glFeedbackBuffer(int size, uint type, float* buffer)
        => _c07b5e08(size, type, buffer);
    public static void glSelectBuffer(int size, uint* buffer)
        => _77dde102(size, buffer);
    public static int glRenderMode(uint mode)
        => _2387af4a(mode);
    public static void glInitNames()
        => _65cffbae();
    public static void glLoadName(uint name)
        => _affed860(name);
    public static void glPassThrough(float token)
        => _02490811(token);
    public static void glPopName()
        => _9f9c5f4c();
    public static void glPushName(uint name)
        => _c7ff8379(name);
    public static void glClearAccum(float red, float green, float blue, float alpha)
        => _95eee1a8(red, green, blue, alpha);
    public static void glClearIndex(float c)
        => _1b048ed3(c);
    public static void glIndexMask(uint mask)
        => _4781d9a1(mask);
    public static void glAccum(uint op, float value)
        => _1c15bdc4(op, value);
    public static void glPopAttrib()
        => _489c9d7d();
    public static void glPushAttrib(uint mask)
        => _db36041e(mask);
    public static void glMap1d(uint target, double u1, double u2, int stride, int order, double* points)
        => _337b9b25(target, u1, u2, stride, order, points);
    public static void glMap1f(uint target, float u1, float u2, int stride, int order, float* points)
        => _7263f26d(target, u1, u2, stride, order, points);
    public static void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
        => _08c95560(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    public static void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
        => _7bf18b7b(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    public static void glMapGrid1d(int un, double u1, double u2)
        => _b965fa86(un, u1, u2);
    public static void glMapGrid1f(int un, float u1, float u2)
        => _9f979e20(un, u1, u2);
    public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2)
        => _32a15f26(un, u1, u2, vn, v1, v2);
    public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2)
        => _620f8096(un, u1, u2, vn, v1, v2);
    public static void glEvalCoord1d(double u)
        => _75d7dc91(u);
    public static void glEvalCoord1dv(double* u)
        => _e7c3d5b5(u);
    public static void glEvalCoord1f(float u)
        => _faec20e0(u);
    public static void glEvalCoord1fv(float* u)
        => _aa0cee40(u);
    public static void glEvalCoord2d(double u, double v)
        => _1576bacd(u, v);
    public static void glEvalCoord2dv(double* u)
        => _4c9fcd77(u);
    public static void glEvalCoord2f(float u, float v)
        => _b78e37fa(u, v);
    public static void glEvalCoord2fv(float* u)
        => _4f3e1210(u);
    public static void glEvalMesh1(uint mode, int i1, int i2)
        => _39c162c6(mode, i1, i2);
    public static void glEvalPoint1(int i)
        => _aa197ab7(i);
    public static void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2)
        => _09332c3d(mode, i1, i2, j1, j2);
    public static void glEvalPoint2(int i, int j)
        => _5a98516c(i, j);
    public static void glAlphaFunc(uint func, float @ref)
        => _028c9a04(func, @ref);
    public static void glPixelZoom(float xfactor, float yfactor)
        => _1536aa22(xfactor, yfactor);
    public static void glPixelTransferf(uint pname, float param)
        => _527c14e0(pname, param);
    public static void glPixelTransferi(uint pname, int param)
        => _5ce387c1(pname, param);
    public static void glPixelMapfv(uint map, int mapsize, float* values)
        => _9b074d83(map, mapsize, values);
    public static void glPixelMapuiv(uint map, int mapsize, uint* values)
        => _8324eaaa(map, mapsize, values);
    public static void glPixelMapusv(uint map, int mapsize, ushort* values)
        => _4e92517a(map, mapsize, values);
    public static void glCopyPixels(int x, int y, int width, int height, uint type)
        => _db49418a(x, y, width, height, type);
    public static void glDrawPixels(int width, int height, uint format, uint type, void* pixels)
        => _4dcbe34b(width, height, format, type, pixels);
    public static void glGetClipPlane(uint plane, double* equation)
        => _4692fc25(plane, equation);
    public static void glGetLightfv(uint light, uint pname, float* @params)
        => _669f20fd(light, pname, @params);
    public static void glGetLightiv(uint light, uint pname, int* @params)
        => _c8b6feb9(light, pname, @params);
    public static void glGetMapdv(uint target, uint query, double* v)
        => _af44dfb9(target, query, v);
    public static void glGetMapfv(uint target, uint query, float* v)
        => _8e4d1277(target, query, v);
    public static void glGetMapiv(uint target, uint query, int* v)
        => _ba6cd407(target, query, v);
    public static void glGetMaterialfv(uint face, uint pname, float* @params)
        => _3e37f3f4(face, pname, @params);
    public static void glGetMaterialiv(uint face, uint pname, int* @params)
        => _8249da76(face, pname, @params);
    public static void glGetPixelMapfv(uint map, float* values)
        => _37232ea7(map, values);
    public static void glGetPixelMapuiv(uint map, uint* values)
        => _cf6364c6(map, values);
    public static void glGetPixelMapusv(uint map, ushort* values)
        => _3807c24f(map, values);
    public static void glGetPolygonStipple(byte* mask)
        => _ae2cfa54(mask);
    public static void glGetTexEnvfv(uint target, uint pname, float* @params)
        => _77f98f04(target, pname, @params);
    public static void glGetTexEnviv(uint target, uint pname, int* @params)
        => _b350ea0d(target, pname, @params);
    public static void glGetTexGendv(uint coord, uint pname, double* @params)
        => _6d944f58(coord, pname, @params);
    public static void glGetTexGenfv(uint coord, uint pname, float* @params)
        => _86c87c31(coord, pname, @params);
    public static void glGetTexGeniv(uint coord, uint pname, int* @params)
        => _f801871f(coord, pname, @params);
    public static bool glIsList(uint list)
        => _33becbea(list);
    public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar)
        => _73fb0eda(left, right, bottom, top, zNear, zFar);
    public static void glLoadIdentity()
        => _1b5ecb65();
    public static void glLoadMatrixf(float* m)
        => _bd37620a(m);
    public static void glLoadMatrixd(double* m)
        => _f07f2ee3(m);
    public static void glMatrixMode(uint mode)
        => _243b542a(mode);
    public static void glMultMatrixf(float* m)
        => _4be38bd2(m);
    public static void glMultMatrixd(double* m)
        => _feb81336(m);
    public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar)
        => _3b902c5c(left, right, bottom, top, zNear, zFar);
    public static void glPopMatrix()
        => _b7330842();
    public static void glPushMatrix()
        => _4c4cebb6();
    public static void glRotated(double angle, double x, double y, double z)
        => _0cc0ada5(angle, x, y, z);
    public static void glRotatef(float angle, float x, float y, float z)
        => _6e803879(angle, x, y, z);
    public static void glScaled(double x, double y, double z)
        => _3dfce7c4(x, y, z);
    public static void glScalef(float x, float y, float z)
        => _56360ea2(x, y, z);
    public static void glTranslated(double x, double y, double z)
        => _6b320264(x, y, z);
    public static void glTranslatef(float x, float y, float z)
        => _4ecdb9da(x, y, z);
    public static void glDrawArrays(uint mode, int first, int count)
        => _01d8be9e(mode, first, count);
    public static void glDrawElements(uint mode, int count, uint type, void* indices)
        => _3434f3d5(mode, count, type, indices);
    public static void glGetPointerv(uint pname, void* @params)
        => _893b8618(pname, @params);
    public static void glPolygonOffset(float factor, float units)
        => _cafc6a15(factor, units);
    public static void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
        => _7425775f(target, level, internalformat, x, y, width, border);
    public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
        => _05fa3b3d(target, level, internalformat, x, y, width, height, border);
    public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
        => _c953c099(target, level, xoffset, x, y, width);
    public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        => _b5f2e5b5(target, level, xoffset, yoffset, x, y, width, height);
    public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels)
        => _d109dba5(target, level, xoffset, width, format, type, pixels);
    public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels)
        => _65dfd7a5(target, level, xoffset, yoffset, width, height, format, type, pixels);
    public static void glBindTexture(uint target, uint texture)
        => _dbafbeec(target, texture);
    public static void glDeleteTextures(int n, uint* textures)
        => _6d2ff7b1(n, textures);
    public static void glGenTextures(int n, uint* textures)
        => _48a443e4(n, textures);
    public static bool glIsTexture(uint texture)
        => _3f0e63e4(texture);
    public static void glArrayElement(int i)
        => _d6b03661(i);
    public static void glColorPointer(int size, uint type, int stride, void* pointer)
        => _7431f153(size, type, stride, pointer);
    public static void glDisableClientState(uint array)
        => _8e06463d(array);
    public static void glEdgeFlagPointer(int stride, void* pointer)
        => _b468ef7c(stride, pointer);
    public static void glEnableClientState(uint array)
        => _1376a10b(array);
    public static void glIndexPointer(uint type, int stride, void* pointer)
        => _19f25888(type, stride, pointer);
    public static void glInterleavedArrays(uint format, int stride, void* pointer)
        => _ce62da50(format, stride, pointer);
    public static void glNormalPointer(uint type, int stride, void* pointer)
        => _d8589b45(type, stride, pointer);
    public static void glTexCoordPointer(int size, uint type, int stride, void* pointer)
        => _c5ed1c61(size, type, stride, pointer);
    public static void glVertexPointer(int size, uint type, int stride, void* pointer)
        => _6902b086(size, type, stride, pointer);
    public static bool glAreTexturesResident(int n, uint* textures, bool* residences)
        => _c5daf0ec(n, textures, residences);
    public static void glPrioritizeTextures(int n, uint* textures, float* priorities)
        => _79045508(n, textures, priorities);
    public static void glIndexub(byte c)
        => _13dd9132(c);
    public static void glIndexubv(byte* c)
        => _71eb817e(c);
    public static void glPopClientAttrib()
        => _317e3149();
    public static void glPushClientAttrib(uint mask)
        => _fe512606(mask);
    #endregion
}
