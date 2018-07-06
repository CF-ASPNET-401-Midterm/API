My API
======
**Version:** v1

### /api/playlist
---
##### ***GET***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |

**Responses**

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 | Success | [ [Playlist](#playlist) ] |

##### ***POST***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| playlist | body |  | No | [Playlist](#playlist) |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

##### ***PUT***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |
| name | body |  | No | string |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /api/playlist/{id}
---
##### ***GET***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

##### ***DELETE***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /api/song
---
##### ***GET***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |

**Responses**

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 | Success | [ [Song](#song) ] |

##### ***POST***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| song | body |  | No | [Song](#song) |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /api/song/{id}
---
##### ***GET***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

##### ***PUT***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |
| playlistID | body |  | No | integer |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

##### ***DELETE***
**Parameters**

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### Models
---

### Playlist  

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | integer |  | No |
| name | string |  | No |
| genreID | integer |  | No |
| songs | [ [Song](#song) ] |  | No |

### Song  

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | integer |  | No |
| name | string |  | No |
| artist | string |  | No |
| album | string |  | No |
| genre | string |  | No |
| playlistID | integer |  | No |
| releaseDate | dateTime |  | No |