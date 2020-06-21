import React, { Component } from 'react';

export class FiverrItem extends Component {
    render() {
        return (
            <div>
                <p>{this.props.fiverrItem.id}</p>
            </div>
        )
    }
}

export default FiverrItem;