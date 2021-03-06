float mDelta = 40; // Pixels. The width border at the edge in which the movement work
    private float speed = 35.0f; // More components use it should be same speed for all of them
 
    private Vector3 mRightDirection = Vector3.right; // Direction the camera should move when on the right edge
 
    void Update()
    {
        Debug.Log(Input.mousePosition);
        // Check if on the right edge
        if (Input.mousePosition.x >= Screen.width - mDelta)
        {
            // Move the camera right
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
        // Check if on the left edge
        if ( Input.mousePosition.x <= 0 + mDelta)
        {
            // Move the camera left
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
        }
        // Check if on the top edge
        if ( Input.mousePosition.y >= Screen.height - mDelta )
            {
            // Move the camera top
            transform.Rotate(Vector3.left, speed * Time.deltaTime );
        }
        // Check if on the bot edge
        if (Input.mousePosition.y <= 0 + mDelta)
        {
            // Move the camera bot
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
        }
    }
